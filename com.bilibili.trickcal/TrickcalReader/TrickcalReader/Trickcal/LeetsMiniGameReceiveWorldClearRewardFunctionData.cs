using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LeetsMiniGameReceiveWorldClearRewardFunctionData {
    [Key(0)]
    public int WorldUid { get; set; }
}
