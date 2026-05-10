using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class IntOrFloatData {
    [Key(0)]
    public int IntData { get; set; }
    [Key(1)]
    public float FloatData { get; set; }
    [Key(2)]
    public bool IsInt { get; set; }
}
