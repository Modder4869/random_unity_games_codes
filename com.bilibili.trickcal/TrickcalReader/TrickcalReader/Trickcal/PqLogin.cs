using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqLogin {
    [Key(0)]
    public bool IsReconnect { get; set; }
    [Key(1)]
    public string DeviceId { get; set; }
    [Key(2)]
    public string SdkDeviceId { get; set; }
    [Key(3)]
    public string Model { get; set; }
    [Key(4)]
    public string OsVersion { get; set; }
    [Key(5)]
    public string Network { get; set; }
    [Key(6)]
    public string Mac { get; set; }
    [Key(7)]
    public string TableVersion { get; set; }
    [Key(8)]
    public string HotFixVersion { get; set; }
    [Key(9)]
    public string Lang { get; set; }
    [Key(10)]
    public string Simulator { get; set; }
    [Key(11)]
    public int AdChannel { get; set; }
}
