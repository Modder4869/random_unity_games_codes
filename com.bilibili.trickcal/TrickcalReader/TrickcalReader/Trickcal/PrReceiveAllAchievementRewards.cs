using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrReceiveAllAchievementRewards {
    [Key(0)]
    public List<int> RewardReceiveQuestUids { get; set; }
}
