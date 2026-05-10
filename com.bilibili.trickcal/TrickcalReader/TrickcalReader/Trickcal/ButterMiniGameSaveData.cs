using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ButterMiniGameSaveData {
    [Key(0)]
    public Dictionary<int, List<ButterMiniGameDifficultyType>> ClearGroupDifficultyMap { get; set; }
    [Key(1)]
    public Dictionary<int, Dictionary<ButterMiniGameDifficultyType, int>> ScoresByGroupDifficulty { get; set; }
}
