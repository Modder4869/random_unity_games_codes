using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrConnectStart {
    [Key(0)]
    public int WrapKey { get; set; }
    [Key(1)]
    public int DummyKey { get; set; }
}
