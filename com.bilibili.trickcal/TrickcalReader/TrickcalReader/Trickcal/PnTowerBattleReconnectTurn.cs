using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnTowerBattleReconnectTurn {
    [Key(0)]
    public int TurnUserId { get; set; }
    [Key(1)]
    public TowerBattleObjectSpawnData ObjectSpawnData { get; set; }
    [Key(2)]
    public double RemainTurnTimeSeconds { get; set; }
}
