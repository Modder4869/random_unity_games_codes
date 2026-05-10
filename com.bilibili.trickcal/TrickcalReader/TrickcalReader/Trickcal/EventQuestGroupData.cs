using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class EventQuestGroupData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public EventQuestUIType EventQuestUIType { get; set; }
    [Key(2)]
    public int EventQuestUid { get; set; }
    [Key(3)]
    public int[] CategoryUid { get; set; }
    [Key(4)]
    public string[] CategoryTextKey { get; set; }
    [Key(5)]
    public string[] CategoryButton { get; set; }
    [Key(6)]
    public int QuestInteractionGroup { get; set; }
    [Key(7)]
    public string QuestBackground { get; set; }
}
