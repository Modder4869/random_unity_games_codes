using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveDailyTimeEventReward {
    [Key(0)]
    public int DailyTimeEventGroupUid { get; set; }
    [Key(1)]
    public int Order { get; set; }
}
