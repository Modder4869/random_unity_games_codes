using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LeetsMiniGameSizeUpFunctionData {
    [Key(0)]
    public int WorldUid { get; set; }
    [Key(1)]
    public int SizeUpCount { get; set; }
    [Key(2)]
    public bool SpecialSizeUp { get; set; }
}
