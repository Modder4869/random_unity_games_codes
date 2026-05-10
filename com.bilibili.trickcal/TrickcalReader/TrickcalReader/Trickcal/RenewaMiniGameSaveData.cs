using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class RenewaMiniGameSaveData {
    [Key(0)]
    public int[] ClearModeUids { get; set; }
    [Key(1)]
    public int[] EasterEggs { get; set; }
    [Key(2)]
    public Dictionary<int, int> ScoresByModeUid { get; set; }
}
