using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetTowerBattleStreakWinRankings {
    [Key(0)]
    public List<TowerBattleStreakWinRankingData> Rankings { get; set; }
}
