using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LifeScheduleLevelUpData : TableItem<TableData> {
    [Key(0)]
    public int Level { get; set; }
    [Key(1)]
    public TableBaseMyHomeLevelUpNeedData Needs { get; set; }
    [Key(2)]
    public bool IsSkip { get; set; }
    [Key(3)]
    public int TaskMaxUp { get; set; }
    [Key(4)]
    public bool IsRepeat { get; set; }
}
