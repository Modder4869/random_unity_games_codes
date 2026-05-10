using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HeroReactionUnlockData : TableItem<TableData> {
    [Key(0)]
    public UnitStandingType UnitType { get; set; }
    [Key(1)]
    public int HeroGradeDefault { get; set; }
    [Key(2)]
    public ReactionType ReactionType { get; set; }
    [Key(3)]
    public int AffinityLv { get; set; }
}
