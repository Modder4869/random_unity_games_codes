using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MiniGameEdAcademyData : TableItem<TableData> {
    [Key(0)]
    public int MiniGameUid { get; set; }
    [Key(1)]
    public int Uid { get; set; }
    [Key(2)]
    public int Group { get; set; }
    [Key(3)]
    public int UnitInfoUid { get; set; }
    [Key(4)]
    public int AcademyLevel { get; set; }
    [Key(5)]
    public int[] NeedRewardValue { get; set; }
    [Key(6)]
    public TowerAcademyStatusType StatusType { get; set; }
    [Key(7)]
    public float StatusValue01 { get; set; }
    [Key(8)]
    public string Name { get; set; }
    [Key(9)]
    public string Desc { get; set; }
    [Key(10)]
    public string Icon { get; set; }
}
