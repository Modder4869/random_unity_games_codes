using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HeroGrowEventQuestData : TableItem<TableData> {
    [Key(0)]
    public TableBaseQuestData QuestData { get; set; }
    [Key(1)]
    public int GroupUid { get; set; }
}
