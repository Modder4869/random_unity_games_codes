using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrConfirmJoinGuild {
    [Key(0)]
    public int GuildId { get; set; }
    [Key(1)]
    public DateTime JoinTime { get; set; }
    [Key(2)]
    public bool IsAlreadyJoined { get; set; }
    [Key(3)]
    public bool IsLevelLimit { get; set; }
    [Key(4)]
    public int JoinRequestCount { get; set; }
}
