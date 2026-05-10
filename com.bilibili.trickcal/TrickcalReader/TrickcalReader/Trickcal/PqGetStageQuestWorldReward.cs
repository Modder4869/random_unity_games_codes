using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqGetStageQuestWorldReward {
    [Key(0)]
    public StageDifficultyType Difficulty { get; set; }
    [Key(1)]
    public int WorldInfoUid { get; set; }
    [Key(2)]
    public int RewardIndex { get; set; }
}
