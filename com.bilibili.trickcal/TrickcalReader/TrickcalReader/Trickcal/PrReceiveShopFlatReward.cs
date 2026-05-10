using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrReceiveShopFlatReward {
    [Key(0)]
    public List<FlatReceivedData> ReceivedDataList { get; set; }
}
