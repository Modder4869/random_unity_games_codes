using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TutorialVideoConditionData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public TutorialVideoCondition Condition { get; set; }
    [Key(2)]
    public int Value { get; set; }
}
