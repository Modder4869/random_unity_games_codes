using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestEndTowerBattle {
    [Key(0)]
    public TowerBattleEndResultData EndResultData { get; set; }
}
