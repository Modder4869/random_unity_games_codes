using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqCheckVersion {
    [Key(0)]
    public OsType OsType { get; set; }
    [Key(1)]
    public int AppVersion { get; set; }
    [Key(2)]
    public int BundleVersion { get; set; }
    [Key(3)]
    public int ProtocolVersion { get; set; }
    [Key(4)]
    public VersionCheckReason Reason { get; set; }
    [Key(5)]
    public string[] IpAddresses { get; set; }
}
