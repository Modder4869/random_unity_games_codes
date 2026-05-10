using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SlotContentsData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public GimmickSlotCategoryType Category { get; set; }
    [Key(2)]
    public string SlotAction { get; set; }
    [Key(3)]
    public GimmickSlotEffectType Type { get; set; }
    [Key(4)]
    public string Name { get; set; }
    [Key(5)]
    public string Desc { get; set; }
    [Key(6)]
    public string Icon { get; set; }
    [Key(7)]
    public int SelectRate { get; set; }
}
