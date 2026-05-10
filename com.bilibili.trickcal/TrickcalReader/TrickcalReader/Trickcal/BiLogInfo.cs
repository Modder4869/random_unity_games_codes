using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class BiLogInfo {
    [Key(0)]
    public int BChannelId { get; set; }
    [Key(1)]
    public string BVersion { get; set; }
    [Key(2)]
    public OsType OsType { get; set; }
    [Key(3)]
    public string Ip { get; set; }
    [Key(4)]
    public string Ipv6 { get; set; }
}
