using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrConfirmAllJoinGuild {
    [Key(0)]
    public int GuildId { get; set; }
    [Key(1)]
    public DateTime JoinTime { get; set; }
    [Key(2)]
    public List<int> UserIdList { get; set; }
    [Key(3)]
    public List<bool> IsAlreadyJoinedList { get; set; }
    [Key(4)]
    public List<ResultCode> ResultCodeList { get; set; }
    [Key(5)]
    public List<bool> IsLevelLimitList { get; set; }
    [Key(6)]
    public int JoinRequestCount { get; set; }
}
