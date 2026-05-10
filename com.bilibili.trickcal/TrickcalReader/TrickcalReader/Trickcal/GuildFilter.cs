using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct GuildFilter {
    [Key(0)]
    public GuildJoinType JoinType { get; set; }
    [Key(1)]
    public GuildActivityType ActivityType { get; set; }
    [Key(2)]
    public short LevelLimit { get; set; }
}
