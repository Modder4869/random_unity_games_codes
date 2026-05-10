using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HeroEquipPresetData : TableItem<TableData> {
    [Key(0)]
    public int HeroInfoUid { get; set; }
    [Key(1)]
    public short Rank { get; set; }
    [Key(2)]
    public int[] SlotArray { get; set; }
}
