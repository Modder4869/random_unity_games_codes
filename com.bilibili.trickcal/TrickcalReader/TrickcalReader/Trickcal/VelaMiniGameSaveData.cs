using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class VelaMiniGameSaveData {
    [Key(0)]
    public Dictionary<int, int> StageScoreMap { get; set; }
    [Key(1)]
    public int[] Endings { get; set; }
}
