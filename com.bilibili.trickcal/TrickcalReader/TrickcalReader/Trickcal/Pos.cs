using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct Pos {
    [Key(0)]
    public float x { get; set; }
    [Key(1)]
    public float y { get; set; }
}
