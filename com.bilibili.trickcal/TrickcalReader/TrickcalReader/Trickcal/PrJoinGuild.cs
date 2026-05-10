using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrJoinGuild {
    [Key(0)]
    public GuildJoinType JoinType { get; set; }
}
