using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ItemBattleData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string Desc { get; set; }
    [Key(2)]
    public string BattleItemAction { get; set; }
    [Key(3)]
    public float[] Param { get; set; }
    [Key(4)]
    public string Icon { get; set; }
    [Key(5)]
    public string Name { get; set; }
}
