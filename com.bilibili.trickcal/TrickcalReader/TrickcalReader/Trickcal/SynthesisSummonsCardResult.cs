using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SynthesisSummonsCardResult {
    [Key(0)]
    public bool IsSuccess { get; set; }
    [Key(1)]
    public int RewardSummonsCardUid { get; set; }
    [Key(2)]
    public List<HeroRewardResult> HeroRewardResult { get; set; }
}
