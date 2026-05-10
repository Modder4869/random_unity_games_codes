using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqContinueLogin {
    [Key(0)]
    public string DeviceId { get; set; }
    [Key(1)]
    public string SdkDeviceId { get; set; }
    [Key(2)]
    public string Model { get; set; }
    [Key(3)]
    public string OsVersion { get; set; }
    [Key(4)]
    public string Network { get; set; }
    [Key(5)]
    public string Mac { get; set; }
    [Key(6)]
    public string Lang { get; set; }
    [Key(7)]
    public string Simulator { get; set; }
    [Key(8)]
    public int AdChannel { get; set; }
}
