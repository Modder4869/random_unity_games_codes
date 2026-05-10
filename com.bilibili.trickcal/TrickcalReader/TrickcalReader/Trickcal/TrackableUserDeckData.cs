using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserDeckData {
    [Key(0)]
    public string Name { get; set; }
    [Key(1)]
    public int[] Heroes { get; set; }
    [Key(2)]
    public short CardDeckIndex { get; set; }
}
