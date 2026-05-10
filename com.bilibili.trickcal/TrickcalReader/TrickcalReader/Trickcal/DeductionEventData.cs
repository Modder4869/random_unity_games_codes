using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DeductionEventData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public int Round { get; set; }
    [Key(3)]
    public string RoundName { get; set; }
    [Key(4)]
    public int DuringDay { get; set; }
    [Key(5)]
    public int RewardDay { get; set; }
    [Key(6)]
    public int BeforeInteraction { get; set; }
    [Key(7)]
    public int AfterStartInteraction { get; set; }
    [Key(8)]
    public int AfterEndInteraction { get; set; }
}
