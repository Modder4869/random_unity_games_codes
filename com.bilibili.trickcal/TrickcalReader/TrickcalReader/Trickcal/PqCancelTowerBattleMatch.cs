using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqCancelTowerBattleMatch {
    [Key(0)]
    public int SeasonId { get; set; }
}
