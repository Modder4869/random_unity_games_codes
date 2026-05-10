using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrSkipStageSelectBattleEventUserSkill {
    [Key(0)]
    public List<Goods> ClearRewards { get; set; }
    [Key(1)]
    public List<List<Goods>> ClearRewardsByStage { get; set; }
}
