using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqChangeGuildMemberRole {
    [Key(0)]
    public int UserId { get; set; }
    [Key(1)]
    public GuildRoleType RoleType { get; set; }
}
