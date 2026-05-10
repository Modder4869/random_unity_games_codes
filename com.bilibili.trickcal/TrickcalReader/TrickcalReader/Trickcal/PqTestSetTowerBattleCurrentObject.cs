using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetTowerBattleCurrentObject {
    [Key(0)]
    public int TowerBattleObjectInfoId { get; set; }
}
