using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct SoloEndKey {
    [Key(0)]
    public int Id { get; set; }
    [Key(1)]
    public int GroupId { get; set; }
}
