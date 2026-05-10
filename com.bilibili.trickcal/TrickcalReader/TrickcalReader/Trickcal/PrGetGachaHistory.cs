using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetGachaHistory {
    [Key(0)]
    public List<GachaHistoryData> GachaHistory { get; set; }
}
