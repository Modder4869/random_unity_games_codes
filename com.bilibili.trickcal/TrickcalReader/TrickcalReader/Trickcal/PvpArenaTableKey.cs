using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct PvpArenaTableKey {
    [Key(0)]
    public int Id { get; set; }
    [Key(1)]
    public GroupType GroupType { get; set; }
}
