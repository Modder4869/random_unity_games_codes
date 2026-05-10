using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqRejoinTowerBattleMatch {
    [Key(0)]
    public int SeasonId { get; set; }
}
