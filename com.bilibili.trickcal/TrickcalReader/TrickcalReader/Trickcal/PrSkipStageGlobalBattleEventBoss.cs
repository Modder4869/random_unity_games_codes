using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrSkipStageGlobalBattleEventBoss {
    [Key(0)]
    public List<Goods> ClearRewards { get; set; }
    [Key(1)]
    public List<List<Goods>> ClearRewardsByStage { get; set; }
    [Key(2)]
    public List<Goods> PlayRewards { get; set; }
    [Key(3)]
    public List<List<Goods>> PlayRewardsByStage { get; set; }
}
