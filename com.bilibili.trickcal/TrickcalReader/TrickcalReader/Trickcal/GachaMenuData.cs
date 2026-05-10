using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GachaMenuData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public GachaCategoryType GachaCategory { get; set; }
    [Key(2)]
    public GachaType GachaType { get; set; }
    [Key(3)]
    public short TabSort { get; set; }
    [Key(4)]
    public bool IsVisible { get; set; }
    [Key(5)]
    public string TitleName { get; set; }
    [Key(6)]
    public string Desc01 { get; set; }
    [Key(7)]
    public string Desc02 { get; set; }
    [Key(8)]
    public ShopSaleType SaleType { get; set; }
    [Key(9)]
    public DateTime? StartDate { get; set; }
    [Key(10)]
    public DateTime? EndDate { get; set; }
    [Key(11)]
    public string Link { get; set; }
    [Key(12)]
    public string VideoData { get; set; }
    [Key(13)]
    public string GachaSubBtn { get; set; }
    [Key(14)]
    public string Background { get; set; }
    [Key(15)]
    public string Border { get; set; }
    [Key(16)]
    public string TitleImg { get; set; }
    [Key(17)]
    public string LimitedTimeBg { get; set; }
    [Key(18)]
    public int[] EventItemUids { get; set; }
    [Key(19)]
    public int[] EventItemExchangeItemUids { get; set; }
    [Key(20)]
    public int[] EventItemExchangeItemCounts { get; set; }
    [Key(21)]
    public short Sort { get; set; }
    [Key(22)]
    public int Group { get; set; }
}
