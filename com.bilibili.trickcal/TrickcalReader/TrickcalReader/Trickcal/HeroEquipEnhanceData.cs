using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HeroEquipEnhanceData : TableItem<TableData> {
    [Key(0)]
    public int Grade { get; set; }
    [Key(1)]
    public short EquipEnhanceLevel { get; set; }
    [Key(2)]
    public TableBaseStatData Stat { get; set; }
}
