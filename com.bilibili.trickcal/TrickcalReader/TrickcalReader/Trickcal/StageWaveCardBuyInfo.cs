using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StageWaveCardBuyInfo {
    [Key(0)]
    public int CardId { get; set; }
    [Key(1)]
    public int TargetId { get; set; }
}
