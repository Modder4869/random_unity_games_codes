using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MyHomeDonationLevelUpData : TableItem<TableData> {
    [Key(0)]
    public int Level { get; set; }
    [Key(1)]
    public bool[] LabApplys { get; set; }
    [Key(2)]
    public int[] Drops { get; set; }
    [Key(3)]
    public TimeSpan MaxTime { get; set; }
    [Key(4)]
    public int NeedFame { get; set; }
    [Key(5)]
    public TableBaseMyHomeLevelUpNeedData Needs { get; set; }
}
