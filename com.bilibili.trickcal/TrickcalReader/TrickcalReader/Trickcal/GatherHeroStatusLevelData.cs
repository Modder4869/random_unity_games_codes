using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GatherHeroStatusLevelData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public GatherStatusType Type { get; set; }
    [Key(2)]
    public int Level { get; set; }
    [Key(3)]
    public int StatusValue { get; set; }
    [Key(4)]
    public int UseItemValue { get; set; }
    [Key(5)]
    public int NeedItem { get; set; }
    [Key(6)]
    public int NeedItemValue { get; set; }
    [Key(7)]
    public int FixedHero { get; set; }
}
