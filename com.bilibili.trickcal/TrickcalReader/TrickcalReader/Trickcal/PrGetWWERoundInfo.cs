using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetWWERoundInfo {
    [Key(0)]
    public Dictionary<int, List<WWEMatchInfoData>> RoundMatchInfos { get; set; }
}
