using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PetAniData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public PetActionType ActionType { get; set; }
    [Key(3)]
    public string AniName { get; set; }
    [Key(4)]
    public int Prob { get; set; }
    [Key(5)]
    public int PeriodMin { get; set; }
    [Key(6)]
    public int PeriodMax { get; set; }
}
