using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TournamentEventStepData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public int Step { get; set; }
    [Key(3)]
    public RewardType RewardType { get; set; }
    [Key(4)]
    public int RewardUid { get; set; }
    [Key(5)]
    public int RewardCount { get; set; }
}
