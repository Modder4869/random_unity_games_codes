using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class EdEditionMiniGameSaveData {
    [Key(0)]
    public Dictionary<int, int> StageClearWaveMap { get; set; }
    [Key(1)]
    public Dictionary<int, int> StageScoreMap { get; set; }
}
