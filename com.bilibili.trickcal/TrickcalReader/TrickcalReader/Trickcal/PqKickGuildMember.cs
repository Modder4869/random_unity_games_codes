using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqKickGuildMember {
    [Key(0)]
    public int UserId { get; set; }
}
