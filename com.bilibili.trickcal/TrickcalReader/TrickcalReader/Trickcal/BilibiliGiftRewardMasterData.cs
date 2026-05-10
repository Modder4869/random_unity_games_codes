using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class BilibiliGiftRewardMasterData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public RewardType RewardType { get; set; }
    [Key(2)]
    public int RewardUid { get; set; }
    [Key(3)]
    public int RewardValue { get; set; }
}
