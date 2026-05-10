using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqContinueAuth {
    [Key(0)]
    public string ContinueAuthToken { get; set; }
    [Key(1)]
    public int ProtocolVersion { get; set; }
    [Key(2)]
    public OsType OsType { get; set; }
    [Key(3)]
    public int AppVersion { get; set; }
    [Key(4)]
    public int BundleVersion { get; set; }
    [Key(5)]
    public string GlobalChannelId { get; set; }
    [Key(6)]
    public string BiliUid { get; set; }
    [Key(7)]
    public string ClientVersion { get; set; }
    [Key(8)]
    public OneSdkInfo OneSdkInfo { get; set; }
    [Key(9)]
    public string TableVersion { get; set; }
    [Key(10)]
    public string HotFixVersion { get; set; }
}
