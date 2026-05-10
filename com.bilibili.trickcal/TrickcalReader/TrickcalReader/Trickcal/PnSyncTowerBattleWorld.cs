using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnSyncTowerBattleWorld {
    [Key(0)]
    public long Timestamp { get; set; }
    [Key(1)]
    public List<TowerBattleObjectTransformData> ObjectTransformDatas { get; set; }
}
