using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AsideLevelData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int HeroInfoUid { get; set; }
    [Key(2)]
    public TableBaseStatData Stat { get; set; }
    [Key(3)]
    public TableBaseStatIncreaseData StatIncrease { get; set; }
}
