using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PetInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string Icon { get; set; }
    [Key(2)]
    public StatusEffect[] EquipTypeStat { get; set; }
    [Key(3)]
    public PetEffectType[] PetEffectTypes { get; set; }
    [Key(4)]
    public string Desc { get; set; }
    [Key(5)]
    public string Detail { get; set; }
    [Key(6)]
    public bool DefaultHold { get; set; }
    [Key(7)]
    public int GetRewardItemUid { get; set; }
    [Key(8)]
    public int GetRewardValue { get; set; }
    [Key(9)]
    public int LevelUpCondition { get; set; }
    [Key(10)]
    public string Spine { get; set; }
    [Key(11)]
    public int ExpRate { get; set; }
    [Key(12)]
    public string CushionIcon { get; set; }
    [Key(13)]
    public float PetSizeMyhome { get; set; }
    [Key(14)]
    public float PetSizeGuild { get; set; }
    [Key(15)]
    public int[] AttributeUids { get; set; }
    [Key(16)]
    public int[] AttributeValues { get; set; }
    [Key(17)]
    public int DefaultAttributeValue { get; set; }
    [Key(18)]
    public string ShopPreviewAni { get; set; }
}
