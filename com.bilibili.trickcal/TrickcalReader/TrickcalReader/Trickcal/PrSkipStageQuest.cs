using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrSkipStageQuest {
    [Key(0)]
    public List<Goods> ClearRewards { get; set; }
    [Key(1)]
    public StageSkipResultType SkipResult { get; set; }
    [Key(2)]
    public int SkipCount { get; set; }
    [Key(3)]
    public List<List<Goods>> ClearRewardsByStage { get; set; }
}
