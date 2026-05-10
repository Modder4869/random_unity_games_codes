using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class RanEditionMiniGameSaveData {
    [Key(0)]
    public Dictionary<int, int> ModeUidToBestScore { get; set; }
    [Key(1)]
    public int[] Endings { get; set; }
}
