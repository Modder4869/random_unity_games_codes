using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqConnectStart {
    [Key(0)]
    public int WrapKey { get; set; }
    [Key(1)]
    public int DummyKey { get; set; }
    [Key(2)]
    public DeviceInfo DeviceInfo { get; set; }
}
