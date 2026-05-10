using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DailyEventData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string TitleImage { get; set; }
    [Key(2)]
    public RewardType[] ExpectRewardType { get; set; }
    [Key(3)]
    public int[] ExpectReward { get; set; }
}
