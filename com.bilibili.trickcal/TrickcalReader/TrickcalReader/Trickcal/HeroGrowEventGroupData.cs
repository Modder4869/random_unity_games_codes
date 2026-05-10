using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HeroGrowEventGroupData : TableItem<TableData> {
    [Key(0)]
    public int EventUid { get; set; }
    [Key(1)]
    public int QuestGroupUid { get; set; }
    [Key(2)]
    public int Sort { get; set; }
    [Key(3)]
    public int UnitUid { get; set; }
    [Key(4)]
    public int PickUpUid { get; set; }
    [Key(5)]
    public int HeroMotionUid { get; set; }
    [Key(6)]
    public int InteractionGroup { get; set; }
    [Key(7)]
    public string Voice { get; set; }
}
