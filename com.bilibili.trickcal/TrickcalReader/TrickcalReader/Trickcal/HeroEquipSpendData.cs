using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HeroEquipSpendData : TableItem<TableData> {
    [Key(0)]
    public short EquipGrade { get; set; }
    [Key(1)]
    public short EquipEnhanceGrade { get; set; }
    [Key(2)]
    public int NeedEnhancePt { get; set; }
}
