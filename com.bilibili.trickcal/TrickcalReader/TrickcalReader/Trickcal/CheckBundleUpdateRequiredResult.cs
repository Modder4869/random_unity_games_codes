using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CheckBundleUpdateRequiredResult {
    [Key(0)]
    public int RequiredBundleVersion { get; set; }
    [Key(1)]
    public string BundleUpdateUrl { get; set; }
    [Key(2)]
    public CdnType CdnType { get; set; }
}
