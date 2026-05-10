using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TowerBattleScoreRankingData {
    [Key(4)]
    public int WinCount { get; set; }
    [Key(5)]
    public int LoseCount { get; set; }
}
