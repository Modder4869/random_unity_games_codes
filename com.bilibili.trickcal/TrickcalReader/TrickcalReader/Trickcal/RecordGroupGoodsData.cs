using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class RecordGroupGoodsData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int RecordTypeUid { get; set; }
    [Key(2)]
    public int Group { get; set; }
    [Key(3)]
    public int CashShopDataUid { get; set; }
}
