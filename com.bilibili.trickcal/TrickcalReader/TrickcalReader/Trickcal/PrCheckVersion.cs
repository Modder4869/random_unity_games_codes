using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrCheckVersion {
    [Key(0)]
    public CheckAppUpdateRequiredResult AppUpdateRequired { get; set; }
    [Key(1)]
    public CheckBundleUpdateRequiredResult BundleUpdateRequired { get; set; }
    [Key(2)]
    public string RedirectServerUrl { get; set; }
    [Key(3)]
    public string BundleUrl { get; set; }
    [Key(4)]
    public string ServerVersion { get; set; }
    [Key(5)]
    public string TableVersion { get; set; }
    [Key(6)]
    public AuthMaintenanceResult Maintenance { get; set; }
    [Key(7)]
    public SerializedGlobalWeightVariableData SerializedGV { get; set; }
    [Key(8)]
    public int RequiredBundleVersion { get; set; }
    [Key(9)]
    public CdnType CdnType { get; set; }
    [Key(10)]
    public ServerType ServerType { get; set; }
    [Key(11)]
    public string ServerName { get; set; }
    [Key(12)]
    public string BundleSuffix { get; set; }
}
