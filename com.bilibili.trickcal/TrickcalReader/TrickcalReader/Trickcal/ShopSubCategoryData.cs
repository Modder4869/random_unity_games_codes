using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ShopSubCategoryData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string SubTab { get; set; }
    [Key(2)]
    public int MainTabUid { get; set; }
    [Key(3)]
    public int SubTabSort { get; set; }
    [Key(4)]
    public bool IsVisible { get; set; }
    [Key(5)]
    public string ShopName { get; set; }
    [Key(6)]
    public ShopSaleType SaleType { get; set; }
    [Key(7)]
    public DateTime? StartDate { get; set; }
    [Key(8)]
    public DateTime? EndDate { get; set; }
    [Key(9)]
    public int ListFlag { get; set; }
    [Key(10)]
    public int ListMax { get; set; }
    [Key(11)]
    public bool ListActive { get; set; }
    [Key(12)]
    public int[] TopUI { get; set; }
    [Key(13)]
    public ShopUISlotType ShopUISlotType { get; set; }
    [Key(14)]
    public string[] BannerImage { get; set; }
    [Key(15)]
    public int[] BannerUid { get; set; }
    [Key(16)]
    public int InteractionGroup { get; set; }
    [Key(17)]
    public bool SoldoutSort { get; set; }
    [Key(18)]
    public bool AllowMultiple { get; set; }
}
