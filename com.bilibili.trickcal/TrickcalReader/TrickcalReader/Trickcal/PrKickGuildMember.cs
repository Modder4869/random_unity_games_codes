using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrKickGuildMember {
    [Key(0)]
    public int GuildId { get; set; }
    [Key(1)]
    public DateTime KickTime { get; set; }
}
