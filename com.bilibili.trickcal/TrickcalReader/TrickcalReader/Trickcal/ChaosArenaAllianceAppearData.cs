using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ChaosArenaAllianceAppearData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public TribeType Required { get; set; }
    [Key(2)]
    public int RequiredCount { get; set; }
    [Key(3)]
    public string AppearType { get; set; }
    [Key(4)]
    public int AppearMonsterGroupUid { get; set; }
    [Key(5)]
    public string AppearTimingType { get; set; }
    [Key(6)]
    public int AppearTimingCount { get; set; }
    [Key(7)]
    public string AppearDurationType { get; set; }
    [Key(8)]
    public int AppearDurationCount { get; set; }
    [Key(9)]
    public int ExtraUnitUid { get; set; }
    [Key(10)]
    public int GroupUid { get; set; }
    [Key(11)]
    public string AppearTypeCondition { get; set; }
}
