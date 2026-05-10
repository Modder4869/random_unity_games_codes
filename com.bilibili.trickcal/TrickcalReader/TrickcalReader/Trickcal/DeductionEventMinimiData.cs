using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DeductionEventMinimiData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public int Round { get; set; }
    [Key(3)]
    public int BeforeOrder { get; set; }
    [Key(4)]
    public int BeforeInteraction { get; set; }
    [Key(5)]
    public int AfterOrder { get; set; }
    [Key(6)]
    public int AfterInteraction { get; set; }
    [Key(7)]
    public int UnitUid { get; set; }
    [Key(8)]
    public DeductionEventTeamType SelectedTeam { get; set; }
}
