using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct Vector2 {
    [Key(0)]
    public float X { get; set; }
    [Key(1)]
    public float Y { get; set; }
}
