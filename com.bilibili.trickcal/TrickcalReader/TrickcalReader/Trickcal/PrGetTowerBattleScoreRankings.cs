using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetTowerBattleScoreRankings {
    [Key(0)]
    public List<TowerBattleScoreRankingData> Rankings { get; set; }
}
