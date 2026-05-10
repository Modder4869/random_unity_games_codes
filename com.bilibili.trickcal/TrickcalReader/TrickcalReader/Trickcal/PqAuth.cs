using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqAuth {
    [Key(0)]
    public OsType OsType { get; set; }
    [Key(1)]
    public AuthType AuthType { get; set; }
    [Key(2)]
    public string Id { get; set; }
    [Key(3)]
    public int AppVersion { get; set; }
    [Key(4)]
    public int BundleVersion { get; set; }
    [Key(5)]
    public int ProtocolVersion { get; set; }
    [Key(6)]
    public PushSubscriptionTypes PushTypes { get; set; }
    [Key(7)]
    public string PushToken { get; set; }
    [Key(8)]
    public string DeviceId { get; set; }
    [Key(9)]
    public bool IsCancelReservationDelete { get; set; }
    [Key(10)]
    public bool IsAdminUser { get; set; }
    [Key(11)]
    public string GPrestoUuid { get; set; }
    [Key(12)]
    public string GPrestoData { get; set; }
    [Key(13)]
    public int GPrestoEngineState { get; set; }
    [Key(14)]
    public string AdId { get; set; }
    [Key(15)]
    public bool IsReconnect { get; set; }
    [Key(16)]
    public string _ { get; set; }
    [Key(17)]
    public string _2 { get; set; }
    [Key(18)]
    public string[] IpAddresses { get; set; }
    [Key(19)]
    public DeviceInfo DeviceInfo { get; set; }
    [Key(20)]
    public string BiliUid { get; set; }
    [Key(21)]
    public string ClientVersion { get; set; }
    [Key(22)]
    public OneSdkInfo OneSdkInfo { get; set; }
}
