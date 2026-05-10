using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnTransferringGuildLeadership {
    [Key(0)]
    public int GuildId { get; set; }
    [Key(1)]
    public int OldUserId { get; set; }
    [Key(2)]
    public int NewUserId { get; set; }
    [Key(3)]
    public GuildRoleType OldUserRole { get; set; }
    [Key(4)]
    public GuildRoleType NewUserRole { get; set; }
    [Key(5)]
    public int JoinRequestCount { get; set; }
}
