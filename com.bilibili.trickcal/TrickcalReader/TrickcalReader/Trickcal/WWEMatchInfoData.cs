using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WWEMatchInfoData {
    [Key(0)]
    public int MatchId { get; set; }
    [Key(1)]
    public WWETeamInfoData Alpha { get; set; }
    [Key(2)]
    public WWETeamInfoData Bravo { get; set; }
    [Key(3)]
    public Dictionary<TeamType, long> Bets { get; set; }
    [Key(4)]
    public TeamType Winner { get; set; }
    [Key(5)]
    public string MatchResultUrl { get; set; }
    [Key(6)]
    public string Desc { get; set; }
}
