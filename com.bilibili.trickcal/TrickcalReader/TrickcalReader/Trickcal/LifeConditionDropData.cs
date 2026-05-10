using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LifeConditionDropData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public int ConditionUid { get; set; }
    [Key(3)]
    public int Weight { get; set; }
    [Key(4)]
    public int EqualHero { get; set; }
    [Key(5)]
    public int[] ExceptHeroes { get; set; }
}
