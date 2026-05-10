using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqGetOpenStageQuestWorldReward {
    [Key(0)]
    public StageDifficultyType Difficulty { get; set; }
    [Key(1)]
    public int WorldInfoUid { get; set; }
}
