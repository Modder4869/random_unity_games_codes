using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnGuildJoinAccept {
    [Key(0)]
    public int GuildId { get; set; }
    [Key(1)]
    public int UserId { get; set; }
    [Key(2)]
    public DateTime JoinTime { get; set; }
    [Key(3)]
    public int JoinRequestCount { get; set; }
}
