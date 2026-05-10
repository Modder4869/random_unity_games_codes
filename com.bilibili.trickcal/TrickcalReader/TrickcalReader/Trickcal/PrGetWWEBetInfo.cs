using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetWWEBetInfo {
    [Key(0)]
    public Dictionary<int, Dictionary<TeamType, long>> Bets { get; set; }
}
