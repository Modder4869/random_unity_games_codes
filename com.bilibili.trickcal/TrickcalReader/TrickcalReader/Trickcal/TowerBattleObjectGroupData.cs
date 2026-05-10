using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TowerBattleObjectGroupData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public int ObjectUid { get; set; }
    [Key(3)]
    public int Weight { get; set; }
}
