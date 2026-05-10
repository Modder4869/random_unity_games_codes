using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnChangeGuildMemberRole {
    [Key(0)]
    public int GuildId { get; set; }
    [Key(1)]
    public int UserId { get; set; }
    [Key(2)]
    public GuildRoleType RoleType { get; set; }
}
