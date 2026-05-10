using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DianaYesterMiniGameSaveData {
    [Key(0)]
    public Dictionary<int, int> StageScoreMap { get; set; }
}
