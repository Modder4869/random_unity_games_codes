using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GachaData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int GachaInfoUid { get; set; }
    [Key(2)]
    public string GachaName { get; set; }
    [Key(3)]
    public ShopLimitType LimitType { get; set; }
    [Key(4)]
    public int LimitCount { get; set; }
    [Key(5)]
    public int Sort { get; set; }
    [Key(6)]
    public NeedItemType NeedItemType { get; set; }
    [Key(7)]
    public int NeedItemUid { get; set; }
    [Key(8)]
    public int NeedItemCount { get; set; }
    [Key(9)]
    public ShopInitializationType InitializationType { get; set; }
    [Key(10)]
    public int Drop { get; set; }
    [Key(11)]
    public int DropCount { get; set; }
    [Key(12)]
    public GachaFixType FixType { get; set; }
    [Key(13)]
    public int FixGrade { get; set; }
    [Key(14)]
    public int FixCount { get; set; }
    [Key(15)]
    public int RewardGachaMileage { get; set; }
    [Key(16)]
    public int RewardPickUpMileage { get; set; }
    [Key(17)]
    public int RewardFreeMileage { get; set; }
    [Key(18)]
    public int ReplaceItemUid { get; set; }
    [Key(19)]
    public int ReplaceItemCount { get; set; }
    [Key(20)]
    public int RewardFirstBonusMileage { get; set; }
    [Key(21)]
    public GachaSpecialMarkType SpecialMarkType { get; set; }
    [Key(22)]
    public int EventMileageItemUid { get; set; }
    [Key(23)]
    public int EventMileageItemCount { get; set; }
    [Key(24)]
    public int RewardCardPickUpMileage { get; set; }
    [Key(25)]
    public GachaGuaranteeType GuaranteeType { get; set; }
    [Key(26)]
    public int GuaranteeValue { get; set; }
    [Key(27)]
    public int Step { get; set; }
    [Key(28)]
    public int NeedItemDiscount { get; set; }
    [Key(29)]
    public RewardType BonusRewardType { get; set; }
    [Key(30)]
    public int BonusRewardUid { get; set; }
    [Key(31)]
    public int BonusRewardCount { get; set; }
}
