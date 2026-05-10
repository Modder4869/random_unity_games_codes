using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnLeaveGuildMember {
    [Key(0)]
    public int GuildId { get; set; }
    [Key(1)]
    public int UserId { get; set; }
}
