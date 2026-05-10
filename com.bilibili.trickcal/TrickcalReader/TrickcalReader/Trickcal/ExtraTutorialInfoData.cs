using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ExtraTutorialInfoData : TableItem<TableData> {
    [Key(0)]
    public int TutorialGroupUid { get; set; }
    [Key(1)]
    public int Order { get; set; }
    [Key(2)]
    public int Drop { get; set; }
    [Key(3)]
    public ExtraTutorialMainConditionType MainCondition { get; set; }
    [Key(4)]
    public int MainValue { get; set; }
    [Key(5)]
    public ExtraTutorialSubConditionType[] SubCondition { get; set; }
    [Key(6)]
    public int[] SubValue { get; set; }
    [Key(7)]
    public int Uid { get; set; }
    [Key(8)]
    public ExtraTutorialMainConditionType EndCondition { get; set; }
    [Key(9)]
    public int EndValue { get; set; }
    [Key(10)]
    public int[] ForceTutorialComplete { get; set; }
    [Key(11)]
    public bool EndCheck { get; set; }
    [Key(12)]
    public bool OnlyForceComplete { get; set; }
}
