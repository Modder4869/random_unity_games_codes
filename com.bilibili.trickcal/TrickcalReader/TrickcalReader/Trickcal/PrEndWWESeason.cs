using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrEndWWESeason {
    [Key(0)]
    public bool IsEnd { get; set; }
    [Key(1)]
    public List<WWEMatchResultInfoData> MatchResultInfoDataList { get; set; }
}
