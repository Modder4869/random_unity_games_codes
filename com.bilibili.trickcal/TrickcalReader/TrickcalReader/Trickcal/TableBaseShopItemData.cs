using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TableBaseShopItemData {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public ShopUIType UIType { get; set; }
    [Key(2)]
    public string Name { get; set; }
    [Key(3)]
    public bool IsVisible { get; set; }
    [Key(4)]
    public int CategoryUid { get; set; }
    [Key(5)]
    public int Sort { get; set; }
    [Key(6)]
    public NeedItemType NeedItemType { get; set; }
    [Key(7)]
    public int NeedItemUid { get; set; }
    [Key(8)]
    public int PriceOriginal { get; set; }
    [Key(9)]
    public int PriceDiscount { get; set; }
    [Key(10)]
    public int DiscountRate { get; set; }
    [Key(11)]
    public ShopProductType ProductType { get; set; }
    [Key(12)]
    public IdCardSaleType IdCardSaleType { get; set; }
    [Key(13)]
    public int ProductUid { get; set; }
    [Key(14)]
    public ShopUnlockType UnlockType { get; set; }
    [Key(15)]
    public int[] UnlockValues { get; set; }
    [Key(16)]
    public ShopLimitType LimitType { get; set; }
    [Key(17)]
    public int LimitCount { get; set; }
    [Key(18)]
    public ShopInitializationType InitializationType { get; set; }
    [Key(19)]
    public int Bonus { get; set; }
    [Key(20)]
    public int BonusCount { get; set; }
    [Key(21)]
    public int FirstBonus { get; set; }
    [Key(22)]
    public int FirstBonusCount { get; set; }
    [Key(23)]
    public ShopReceiveType Receive { get; set; }
    [Key(24)]
    public string Desc { get; set; }
    [Key(25)]
    public string Icon { get; set; }
    [Key(26)]
    public bool Free { get; set; }
    [Key(27)]
    public int RePrint { get; set; }
    [Key(28)]
    public int ShopFlatReserveDays { get; set; }
    [Key(29)]
    public int SubscribeDiscount { get; set; }
    [Key(30)]
    public ShopPopupType PopupType { get; set; }
    [Key(31)]
    public ShopTableType ShopTableType { get; set; }
    [Key(32)]
    public bool IsSoldOutVisible { get; set; }
    [Key(34)]
    public string TagText { get; set; }
    [Key(35)]
    public int[] Tag { get; set; }
}
