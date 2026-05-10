using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnFailedTowerBattleMatch {
    [Key(0)]
    public TowerBattleMatchFailType FailType { get; set; }
}
