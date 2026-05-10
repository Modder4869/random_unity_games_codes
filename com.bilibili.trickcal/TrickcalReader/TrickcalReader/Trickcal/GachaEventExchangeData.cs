using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GachaEventExchangeData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int GachaInfoUid { get; set; }
    [Key(2)]
    public int HeroUid { get; set; }
    [Key(3)]
    public int RequiredMileageItemUid { get; set; }
    [Key(4)]
    public int RequiredMileageCount { get; set; }
    [Key(5)]
    public int ExchangeIdCardCount { get; set; }
}
