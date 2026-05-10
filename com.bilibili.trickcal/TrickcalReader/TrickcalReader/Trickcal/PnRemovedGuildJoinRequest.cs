using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnRemovedGuildJoinRequest {
    [Key(0)]
    public int GuildId { get; set; }
    [Key(1)]
    public int JoinRequestCount { get; set; }
}
