using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GatherHeroNumData : TableItem<TableData> {
    [Key(0)]
    public int HighestStatusLevel { get; set; }
    [Key(1)]
    public int GatherHeroMax { get; set; }
    [Key(2)]
    public int ShineHeroMax { get; set; }
}
