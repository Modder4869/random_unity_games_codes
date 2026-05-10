using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrRejoinTowerBattleMatch {
    [Key(0)]
    public List<TowerBattleObjectTransformData> ObjectTransformDatas { get; set; }
    [Key(1)]
    public int ChangeObjectCount { get; set; }
}
