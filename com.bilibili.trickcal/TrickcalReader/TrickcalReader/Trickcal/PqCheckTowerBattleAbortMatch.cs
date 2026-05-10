using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqCheckTowerBattleAbortMatch {
    [Key(0)]
    public int SeasonId { get; set; }
}
