using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GuildLoginData {
    [Key(0)]
    public GuildRoleType RoleType { get; set; }
    [Key(1)]
    public int JoinRequestCount { get; set; }
}
