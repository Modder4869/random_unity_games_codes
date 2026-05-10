using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class VotingInfo : TableItem<TableData> {
    [Key(0)]
    public int Season { get; set; }
    [Key(1)]
    public VotingEventTeamType[] TeamTypes { get; set; }
    [Key(3)]
    public int VotingGoodsCount { get; set; }
    [Key(4)]
    public int EventGoodsUid { get; set; }
    [Key(5)]
    public int VotingEventOpenDelayHours { get; set; }
    [Key(6)]
    public int RewardGroupId { get; set; }
    [Key(7)]
    public int VotingTerm { get; set; }
    [Key(8)]
    public int MinVotingRatio { get; set; }
    [Key(9)]
    public string[] TeamTypeBGMs { get; set; }
}
