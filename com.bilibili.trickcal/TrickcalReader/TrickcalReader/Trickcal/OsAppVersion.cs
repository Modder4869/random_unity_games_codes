using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct OsAppVersion {
    [Key(0)]
    public OsType OsType { get; set; }
    [Key(1)]
    public int AppVersion { get; set; }
    [Key(2)]
    public bool IsAdminOnly { get; set; }
}
