using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class FlatInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public ModeType Mode { get; set; }
    [Key(2)]
    public FlatBenefitType[] FlatBenefitTypes { get; set; }
    [Key(3)]
    public int[] BenefitValues { get; set; }
    [Key(4)]
    public string[] PopupNames { get; set; }
    [Key(5)]
    public string[] PopupTexts { get; set; }
    [Key(6)]
    public string[] BannerTexts { get; set; }
    [Key(7)]
    public string Icon { get; set; }
    [Key(8)]
    public string HexCode { get; set; }
    [Key(9)]
    public string BenefitStarIcon { get; set; }
    [Key(10)]
    public string PurchaseWarning { get; set; }
    [Key(11)]
    public string NormalSlotIcon { get; set; }
    [Key(12)]
    public string SpecialSlotIcon { get; set; }
    [Key(13)]
    public string EmphasisSlotIcon { get; set; }
    [Key(14)]
    public string SubTitleIcon { get; set; }
    [Key(15)]
    public string SubTitleKey { get; set; }
    [Key(16)]
    public string TitleIcon { get; set; }
    [Key(17)]
    public int PopupSubscribeUnit { get; set; }
    [Key(18)]
    public float PopupSubscribeUnitPosX { get; set; }
    [Key(19)]
    public float PopupSubscribeUnitPosY { get; set; }
    [Key(20)]
    public float PopupSubscribeUnitScale { get; set; }
    [Key(21)]
    public string PopupSubscribeTitle { get; set; }
    [Key(22)]
    public string PopupSubscribeBG { get; set; }
    [Key(23)]
    public string SlotTextColor { get; set; }
    [Key(24)]
    public string ExitIconColor { get; set; }
}
