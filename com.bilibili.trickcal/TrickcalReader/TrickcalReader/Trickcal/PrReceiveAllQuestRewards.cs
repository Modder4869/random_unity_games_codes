using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrReceiveAllQuestRewards {
    [Key(0)]
    public List<int> RewardReceiveQuestUids { get; set; }
    [Key(1)]
    public Dictionary<AutoReceiveQuestReceiveSceneType, List<Goods>> GoodsListGroupByReceiveSceneType { get; set; }
}
