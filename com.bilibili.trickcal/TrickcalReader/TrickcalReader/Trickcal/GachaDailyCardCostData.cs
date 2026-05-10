using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GachaDailyCardCostData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public CardType CardType { get; set; }
    [Key(2)]
    public int Rarity { get; set; }
    [Key(3)]
    public NeedItemType NeedItemType { get; set; }
    [Key(4)]
    public int NeedItemUid { get; set; }
    [Key(5)]
    public int NeedItemCountsMin { get; set; }
    [Key(6)]
    public int NeedItemCountsMax { get; set; }
    [Key(7)]
    public int Rate { get; set; }
}
