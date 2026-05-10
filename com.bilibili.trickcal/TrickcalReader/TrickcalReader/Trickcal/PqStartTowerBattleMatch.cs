using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqStartTowerBattleMatch {
    [Key(0)]
    public int SeasonId { get; set; }
}
