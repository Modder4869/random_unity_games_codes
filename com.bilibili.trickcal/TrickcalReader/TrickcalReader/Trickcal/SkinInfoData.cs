using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SkinInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int UnitUid { get; set; }
    [Key(2)]
    public int ItemUid { get; set; }
    [Key(3)]
    public string SpineBattle { get; set; }
    [Key(4)]
    public string SpineStanding { get; set; }
    [Key(5)]
    public string SpineStandingSkinName { get; set; }
    [Key(6)]
    public string SpineMinimi { get; set; }
    [Key(7)]
    public string SpineMinimiSkinName { get; set; }
    [Key(8)]
    public string InteractPostfix { get; set; }
    [Key(9)]
    public int SortingOrder { get; set; }
    [Key(10)]
    public bool IsDefault { get; set; }
    [Key(11)]
    public string SkinIcon { get; set; }
    [Key(12)]
    public bool IsEquippable { get; set; }
    [Key(13)]
    public string SkinKey { get; set; }
    [Key(14)]
    public string BackStandingEffectSlotName { get; set; }
    [Key(15)]
    public string BackStandingEffectUIName { get; set; }
    [Key(16)]
    public string BackStandingEffect3DName { get; set; }
    [Key(17)]
    public string IngameEffectSlotName { get; set; }
    [Key(18)]
    public string IngameEffectUIName { get; set; }
    [Key(19)]
    public string IngameEffect3DName { get; set; }
    [Key(20)]
    public UnitStandingType UnitType { get; set; }
    [Key(21)]
    public int ProfileItemUid { get; set; }
    [Key(22)]
    public bool IsCountOnPlayerProfile { get; set; }
    [Key(23)]
    public string SpineBattleSkinName { get; set; }
    [Key(24)]
    public string FrontStandingEffectUIName { get; set; }
    [Key(25)]
    public int SkinBGItemUid { get; set; }
    [Key(26)]
    public string FrontStandingEffect3DName { get; set; }
    [Key(27)]
    public string FrontStandingEffectSlotName { get; set; }
    [Key(28)]
    public int PopupOrder { get; set; }
    [Key(29)]
    public string FrontBattleEffectSlotName { get; set; }
    [Key(30)]
    public string FrontBattleEffectUIName { get; set; }
    [Key(31)]
    public string FrontBattleEffect3DName { get; set; }
    [Key(32)]
    public string BackBattleEffectSlotName { get; set; }
    [Key(33)]
    public string BackBattleEffectUIName { get; set; }
    [Key(34)]
    public string BackBattleEffect3DName { get; set; }
}
