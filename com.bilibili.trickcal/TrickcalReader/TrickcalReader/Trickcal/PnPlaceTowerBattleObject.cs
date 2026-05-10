using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnPlaceTowerBattleObject {
    [Key(0)]
    public TowerBattleObjectTransformData ObjectTransformData { get; set; }
}
