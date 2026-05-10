using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqGetTowerBattleScoreRankings {
    [Key(0)]
    public int SeasonId { get; set; }
    [Key(1)]
    public int Page { get; set; }
    [Key(2)]
    public int PageLength { get; set; }
}
