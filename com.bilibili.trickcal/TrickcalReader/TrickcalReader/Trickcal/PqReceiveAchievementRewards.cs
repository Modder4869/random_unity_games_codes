using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveAchievementRewards {
    [Key(0)]
    public int QuestUid { get; set; }
}
