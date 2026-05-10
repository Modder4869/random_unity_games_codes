using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveQuestRewards {
    [Key(0)]
    public int QuestUid { get; set; }
}
