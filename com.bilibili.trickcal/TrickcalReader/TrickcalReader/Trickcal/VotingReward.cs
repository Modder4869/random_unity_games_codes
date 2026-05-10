using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class VotingReward : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public VotingEventTeamType TeamType { get; set; }
    [Key(2)]
    public int Day { get; set; }
    [Key(3)]
    public RewardType[] RewardTypes { get; set; }
    [Key(4)]
    public int[] RewardUids { get; set; }
    [Key(5)]
    public int[] RewardValues { get; set; }
    [Key(6)]
    public bool VotingProcess { get; set; }
    [Key(7)]
    public int GroupId { get; set; }
}
