using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReadyTowerBattlePlay {
    [Key(0)]
    public int SeasonId { get; set; }
}
