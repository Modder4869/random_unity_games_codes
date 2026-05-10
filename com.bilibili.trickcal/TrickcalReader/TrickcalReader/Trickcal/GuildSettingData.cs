using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GuildSettingData {
    [Key(0)]
    public int? EmblemLayer0 { get; set; }
    [Key(1)]
    public int? EmblemLayer1 { get; set; }
    [Key(2)]
    public GuildJoinType? JoinType { get; set; }
    [Key(3)]
    public GuildActivityType? ActivityType { get; set; }
    [Key(4)]
    public short? LevelLimit { get; set; }
}
