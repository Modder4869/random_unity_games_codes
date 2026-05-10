using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrEnterCookingTycoonLobby {
    [Key(0)]
    public int RankingUserTotalCount { get; set; }
}
