using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class EquipInfoData : TableItem<TableData> {
    [Key(0)]
    public TableBaseItemData ItemData { get; set; }
    [Key(1)]
    public EquipType Type { get; set; }
    [Key(2)]
    public short Grade { get; set; }
    [Key(3)]
    public int NeedHeroLevel { get; set; }
    [Key(4)]
    public int EnhancePt { get; set; }
    [Key(5)]
    public TableBaseStatData Stat { get; set; }
}
