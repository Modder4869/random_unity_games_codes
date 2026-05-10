using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnChangeTowerBattleObject {
    [Key(0)]
    public TowerBattleObjectSpawnData ObjectSpawnData { get; set; }
    [Key(1)]
    public DateTime TurnEndTime { get; set; }
}
