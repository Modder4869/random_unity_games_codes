using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WWEUnitScaleData {
    [Key(2)]
    public float ScaleX { get; set; }
    [Key(3)]
    public float ScaleY { get; set; }
    [Key(4)]
    public float ScaleZ { get; set; }
}
