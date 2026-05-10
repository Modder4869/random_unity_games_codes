using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HeroRankData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int HeroInfoUid { get; set; }
    [Key(2)]
    public int Rank { get; set; }
    [Key(3)]
    public TableBaseStatData Stat { get; set; }
    [Key(4)]
    public OutGameStatType[] AllStatTypes { get; set; }
    [Key(5)]
    public float[] AllStatValues { get; set; }
}
