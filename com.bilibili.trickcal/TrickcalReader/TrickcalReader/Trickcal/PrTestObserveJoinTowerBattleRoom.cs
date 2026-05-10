using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrTestObserveJoinTowerBattleRoom {
    [Key(0)]
    public List<TowerBattleObjectStateSnapshotData> ObjectStateSnapshotDatas { get; set; }
}
