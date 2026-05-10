using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GuildDetailData {
    [Key(0)]
    public int GuildId { get; set; }
    [Key(1)]
    public string Name { get; set; }
    [Key(2)]
    public int EmblemLayer0 { get; set; }
    [Key(3)]
    public int EmblemLayer1 { get; set; }
    [Key(4)]
    public GuildJoinType JoinType { get; set; }
    [Key(5)]
    public GuildActivityType ActivityType { get; set; }
    [Key(6)]
    public short LevelLimit { get; set; }
    [Key(7)]
    public short MemberCount { get; set; }
}
