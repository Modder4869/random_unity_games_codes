using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct QuestRewardData {
    [Key(0)]
    public int QuestUid { get; set; }
    [Key(1)]
    public Goods[] Rewards { get; set; }
}
