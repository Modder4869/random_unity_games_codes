using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnTowerBattleTurnTimeOver {
    [Key(0)]
    public TowerBattleObjectTransformData ObjectTransformData { get; set; }
}
