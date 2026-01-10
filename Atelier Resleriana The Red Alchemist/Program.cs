using AddressablesTools;
using AddressablesTools.Catalog;
using AddressablesTools.Classes;
using AssetsTools.NET;
using AtelierTool;

static void SearchExample(string[] args)
{
    if (args.Length < 2)
    {
        Console.WriteLine("need path to catalog.json");
        return;
    }

    bool fromBundle = IsUnityFS(args[1]);

    ContentCatalogData ccd;
    if (fromBundle)
    {
        ccd = AddressablesCatalogFileParser.FromBundle(args[1]);
    }
    else
    {
        CatalogFileType fileType;
        using (FileStream fs = File.OpenRead(args[1]))
        {
            fileType = AddressablesCatalogFileParser.GetCatalogFileType(fs);
        }

        if (fileType == CatalogFileType.Json)
        {
            ccd = AddressablesCatalogFileParser.FromJsonString(File.ReadAllText(args[1]));
        }
        else if (fileType == CatalogFileType.Binary)
        {
            ccd = AddressablesCatalogFileParser.FromBinaryData(File.ReadAllBytes(args[1]));
        }
        else
        {
            Console.WriteLine("not a valid catalog file");
            return;
        }
    }

    Console.Write("search key to find bundles of: ");
    string? search = Console.ReadLine();

    if (search == null)
    {
        return;
    }

    search = search.ToLower();
    foreach (object k in ccd.Resources.Keys)
    {
        if (k is string s && s.ToLower().Contains(search))
        {
            Console.Write(s);
            var rsrcs = ccd.Resources[s];
            foreach (var rsrc in rsrcs)
            {
                Console.WriteLine($" (id: {rsrc.InternalId}, prov: {rsrc.ProviderId})");
                if (rsrc.ProviderId == "UnityEngine.ResourceManagement.ResourceProviders.AssetBundleProvider")
                {
                    var data = rsrc.Data;
                    if (data is WrappedSerializedObject { Object: AssetBundleRequestOptions abro })
                    {
                        uint crc = abro.Crc;

                        Console.WriteLine($"  crc = {crc:x8}");
                    }
                }

                else if (rsrc.ProviderId == "UnityEngine.ResourceManagement.ResourceProviders.BundledAssetProvider")
                {
                    List<ResourceLocation> locs;
                    if (rsrc.Dependencies != null)
                    {
                        // new version
                        locs = rsrc.Dependencies;
                    }
                    else if (rsrc.DependencyKey != null)
                    {
                        // old version
                        locs = ccd.Resources[rsrc.DependencyKey];
                    }
                    else
                    {
                        continue;
                    }

                    Console.WriteLine($"  {locs[0].InternalId}");
                    if (locs.Count > 1)
                    {
                        for (int i = 1; i < locs.Count; i++)
                        {
                            Console.WriteLine($"    {locs[i].InternalId}");
                        }
                    }
                }
            }
        }
    }
}
static ContentCatalogData LoadCatalog(string path)
{
    if (!File.Exists(path))
        throw new FileNotFoundException("Catalog file not found", path);

    bool fromBundle = IsUnityFS(path);

    if (fromBundle)
    {
        // Load catalog from UnityFS bundle
        return AddressablesCatalogFileParser.FromBundle(path);
    }
    else
    {
        // Determine catalog type
        CatalogFileType fileType;
        using (FileStream fs = File.OpenRead(path))
        {
            fileType = AddressablesCatalogFileParser.GetCatalogFileType(fs);
        }

        return fileType switch
        {
            CatalogFileType.Json => AddressablesCatalogFileParser.FromJsonString(File.ReadAllText(path)),
            CatalogFileType.Binary => AddressablesCatalogFileParser.FromBinaryData(File.ReadAllBytes(path)),
            _ => throw new Exception("Not a valid catalog file")
        };
    }
}

static bool IsUnityFS(string path)
{
    const string unityFs = "UnityFS";
    using AssetsFileReader reader = new AssetsFileReader(path);
    if (reader.BaseStream.Length < unityFs.Length)
    {
        return false;
    }

    return reader.ReadStringLength(unityFs.Length) == unityFs;
}

static void PatchCrcRecursive(ResourceLocation thisRsrc, HashSet<ResourceLocation> seenRsrcs)
{
    // I think this can't happen right now, resources are duplicated every time
    if (seenRsrcs.Contains(thisRsrc))
        return;

    var data = thisRsrc.Data;
    if (data is WrappedSerializedObject { Object: AssetBundleRequestOptions abro })
    {
        abro.Crc = 0;
    }

    seenRsrcs.Add(thisRsrc);
    foreach (var childRsrc in thisRsrc.Dependencies)
    {
        PatchCrcRecursive(childRsrc, seenRsrcs);
    }
}

static void PatchCrcExample(string[] args)
{
    if (args.Length < 2)
    {
        Console.WriteLine("need path to catalog.json");
        return;
    }

    bool fromBundle = IsUnityFS(args[1]);

    ContentCatalogData ccd;
    CatalogFileType fileType = CatalogFileType.None;
    if (fromBundle)
    {
        ccd = AddressablesCatalogFileParser.FromBundle(args[1]);
    }
    else
    {
        using (FileStream fs = File.OpenRead(args[1]))
        {
            fileType = AddressablesCatalogFileParser.GetCatalogFileType(fs);
        }

        switch (fileType)
        {
            case CatalogFileType.Json:
                ccd = AddressablesCatalogFileParser.FromJsonString(File.ReadAllText(args[1]));
                break;
            case CatalogFileType.Binary:
                ccd = AddressablesCatalogFileParser.FromBinaryData(File.ReadAllBytes(args[1]));
                break;
            default:
                Console.WriteLine("not a valid catalog file");
                return;
        }
    }

    Console.WriteLine("patching...");

    var seenRsrcs = new HashSet<ResourceLocation>();
    foreach (var resourceList in ccd.Resources.Values)
    {
        foreach (var rsrc in resourceList)
        {
            if (rsrc.Dependencies != null)
            {
                // we just spotted a new version entry, switch to new entry parsing
                PatchCrcRecursive(rsrc, seenRsrcs);
                continue;
            }

            if (rsrc.ProviderId == "UnityEngine.ResourceManagement.ResourceProviders.AssetBundleProvider")
            {
                // old version
                var data = rsrc.Data;
                if (data is WrappedSerializedObject { Object: AssetBundleRequestOptions abro })
                {
                    abro.Crc = 0;
                }
            }
        }
    }

    if (fromBundle)
    {
        AddressablesCatalogFileParser.ToBundle(ccd, args[1], args[1] + ".patched");
    }
    else
    {
        switch (fileType)
        {
            case CatalogFileType.Json:
                File.WriteAllText(args[1] + ".patched", AddressablesCatalogFileParser.ToJsonString(ccd));
                break;
            case CatalogFileType.Binary:
                File.WriteAllBytes(args[1] + ".patched", AddressablesCatalogFileParser.ToBinaryData(ccd));
                break;
            default:
                return;
        }
    }

    File.Move(args[1], args[1] + ".old", true);
    File.Move(args[1] + ".patched", args[1], true);
}

static List<(string Filename, string InternalId, string ProviderId)> SearchByFilename(ContentCatalogData ccd, string search)
{
    var results = new List<(string Filename, string InternalId, string ProviderId)>();
    if (string.IsNullOrWhiteSpace(search) || ccd == null)
        return results;

    search = search.ToLower();

    foreach (var kvp in ccd.Resources)
    {
        foreach (var rsrc in kvp.Value)
        {
            string filename = Path.GetFileName(rsrc.InternalId ?? "");
            if (!string.IsNullOrEmpty(filename) && filename.ToLower().Contains(search))
            {
                results.Add((filename, rsrc.InternalId ?? "", rsrc.ProviderId ?? ""));
            }
        }
    }

    return results;
}
static Dictionary<string, (string BundleName, string Hash, uint Crc, string InternalId)> BuildFilenameDictionary(ContentCatalogData ccd)
{
    var dict = new Dictionary<string, (string BundleName, string Hash, uint Crc, string InternalId)>(StringComparer.OrdinalIgnoreCase);

    foreach (var kvp in ccd.Resources)
    {
        foreach (var rsrc in kvp.Value)
        {
            string filename = Path.GetFileName(rsrc.InternalId ?? "");
            if (string.IsNullOrEmpty(filename))
                continue;

            if (rsrc.ProviderId == "UnityEngine.ResourceManagement.ResourceProviders.AssetBundleProvider" ||
                rsrc.ProviderId == "UnityEngine.ResourceManagement.ResourceProviders.CustomAssetBundleProvider")
            {
                if (rsrc.Data is WrappedSerializedObject { Object: AssetBundleRequestOptions abro })
                {
                    string bundleName = abro.BundleName;
                    string hash = abro.Hash;
                    uint crc = abro.Crc;
                    string internalId = rsrc.InternalId ?? "";
                    if (!dict.ContainsKey(filename))
                        dict[filename] = (bundleName, hash, crc, internalId);
                }
            }
        }
    }

    return dict;
}

static (string Filename, string BundleName, string Hash, uint Crc, string InternalId, string SecretToken)? LookupByFilename(ContentCatalogData ccd, string searchPath)
{
    string searchFilename = Path.GetFileName(searchPath);
    var filenameDict = BuildFilenameDictionary(ccd);

    if (filenameDict.TryGetValue(searchFilename, out var info))
    {
        string secretToken = $"{info.BundleName}_{info.Hash}-{info.Crc}";
        return (searchFilename, info.BundleName, info.Hash, info.Crc, info.InternalId, secretToken);
    }

    return null;
}


static void DecryptExample(string[] args)
{
    if (args.Length < 3)
    {
        Console.WriteLine("Usage: decrypt <catalog.json> <inputFolder> <outputFolder>");
        return;
    }

    string catalogPath = args[1];
    string inputFolder = args[2];
    string outputFolder = args[3];

    if (!Directory.Exists(inputFolder))
    {
        Console.WriteLine($"Input folder '{inputFolder}' does not exist.");
        return;
    }

    if (!Directory.Exists(outputFolder))
    {
        Directory.CreateDirectory(outputFolder);
    }

    var ccd = LoadCatalog(catalogPath);
    var files = Directory.GetFiles(inputFolder);

    foreach (var filePath in files)
    {
        var result = LookupByFilename(ccd, filePath);
        if (result == null)
        {
            Console.WriteLine($"File '{filePath}' not found in catalog, skipping.");
            continue;
        }

        byte[] data =  File.ReadAllBytes(filePath);
        byte[] expectedHeader = { 0x45, 0x6E, 0x63, 0x72, 0x79, 0x70, 0x74, 0x69, 0x6F, 0x6E };
        if (data.Length < expectedHeader.Length || !data.Take(expectedHeader.Length).SequenceEqual(expectedHeader))
        {
            Console.WriteLine($"File '{filePath}' does not have encrypted header, skipping.");
            continue;
        }

        string keyMaterial = result.Value.SecretToken;
        using var decStream = BundleCrypto.DecryptBundle(data, keyMaterial);
        string outputPath = Path.Combine(outputFolder, Path.GetFileName(filePath) + "_dec");

        using var fs = File.OpenWrite(outputPath);
        decStream.CopyTo(fs);

        Console.WriteLine($"Decrypted '{filePath}' to '{outputPath}'");
    }
}



if (args.Length < 1)
{
    Console.WriteLine("need args: <mode> <file>");
    Console.WriteLine("modes: searchasset, patchcrc");
}
else if (args[0] == "searchasset")
{
    SearchExample(args);
}
else if (args[0] == "patchcrc")
{
    PatchCrcExample(args);
}
else if (args[0] == "decrypt")
{
    DecryptExample(args);
}

else
{
    Console.WriteLine("mode not supported");
}