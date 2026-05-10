using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestAddQuestCount {
    [Key(0)]
    public QuestType QuestType { get; set; }
    [Key(1)]
    public long Count { get; set; }
}
