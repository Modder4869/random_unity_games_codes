using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DeductionEventTeamData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public int Round { get; set; }
    [Key(3)]
    public bool IsWin { get; set; }
    [Key(4)]
    public DeductionEventTeamType TeamType { get; set; }
    [Key(5)]
    public string TeamImage { get; set; }
    [Key(6)]
    public string TeamName { get; set; }
    [Key(7)]
    public RewardType[] RewardTypes { get; set; }
    [Key(8)]
    public int[] RewardUids { get; set; }
    [Key(9)]
    public int[] RewardValues { get; set; }
}
