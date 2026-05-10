using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrReadEpisode {
    [Key(0)]
    public bool IsSkippableStory { get; set; }
    [Key(1)]
    public bool IsRewardAlreadyReceived { get; set; }
    [Key(2)]
    public int ScheduleStoryRewardAffinity { get; set; }
    [Key(3)]
    public int ScheduleStoryRewardCondition { get; set; }
}
