using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReconnectReadyTowerBattlePlay {
    [Key(0)]
    public int SeasonId { get; set; }
}
