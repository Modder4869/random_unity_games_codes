using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WWEMatchResultInfoData {
    [Key(0)]
    public int Round { get; set; }
    [Key(1)]
    public int Index { get; set; }
    [Key(2)]
    public TeamType WinnerTeam { get; set; }
    [Key(3)]
    public TeamType BetTeam { get; set; }
    [Key(4)]
    public RewardData[] Reward { get; set; }
}
