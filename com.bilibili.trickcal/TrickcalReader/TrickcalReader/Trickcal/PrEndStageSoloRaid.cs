using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrEndStageSoloRaid {
    [Key(0)]
    public bool IsClear { get; set; }
    [Key(1)]
    public bool IsFirstClear { get; set; }
    [Key(2)]
    public List<Goods> FirstClearRewards { get; set; }
    [Key(3)]
    public List<Goods> ClearRewards { get; set; }
    [Key(4)]
    public long StageScore { get; set; }
    [Key(5)]
    public long TimeBonus { get; set; }
    [Key(6)]
    public short StagePlayCount { get; set; }
}
