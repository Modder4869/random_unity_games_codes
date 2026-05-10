using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class JoanneMiniGameSaveData {
    [Key(0)]
    public Dictionary<int, int> ModeScoreMap { get; set; }
    [Key(1)]
    public int[] Endings { get; set; }
}
