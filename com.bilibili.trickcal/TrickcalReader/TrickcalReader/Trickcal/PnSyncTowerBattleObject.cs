using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnSyncTowerBattleObject {
    [Key(0)]
    public TowerBattleObjectTransformData ObjectTransformData { get; set; }
}
