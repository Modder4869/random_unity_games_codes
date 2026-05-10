using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ItemArtifactData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public bool Available { get; set; }
    [Key(2)]
    public int Cost { get; set; }
    [Key(3)]
    public int Tier { get; set; }
    [Key(4)]
    public int SelectRate { get; set; }
    [Key(5)]
    public bool Repetition { get; set; }
    [Key(6)]
    public DrawCardConditionType DrawCardCondition { get; set; }
    [Key(7)]
    public int ConditionValue { get; set; }
    [Key(8)]
    public ArtifactEffectType AddEffectType { get; set; }
    [Key(9)]
    public string Icon { get; set; }
    [Key(10)]
    public string ArtifactEquipAction { get; set; }
    [Key(11)]
    public StatusEffect[] EquipTypeStat { get; set; }
    [Key(12)]
    public string[] EquipStatIcon { get; set; }
    [Key(14)]
    public string Desc { get; set; }
    [Key(15)]
    public string EffectDesc { get; set; }
    [Key(16)]
    public string Detail { get; set; }
    [Key(17)]
    public bool DefaultHold { get; set; }
    [Key(18)]
    public int GetRewardItemUid { get; set; }
    [Key(19)]
    public int GetRewardValue { get; set; }
    [Key(20)]
    public int LevelUpCondition { get; set; }
    [Key(21)]
    public RecommendCore RecommendCore1 { get; set; }
    [Key(22)]
    public RecommendCore RecommendCore2 { get; set; }
    [Key(23)]
    public bool ObjectInherit { get; set; }
    [Key(24)]
    public int SignatureCardHeroUid { get; set; }
    [Key(25)]
    public int SignatureCardUid { get; set; }
    [Key(26)]
    public TableBaseCardData CardData { get; set; }
    [Key(27)]
    public string StackIcon { get; set; }
    [Key(28)]
    public string[] EquipTypeStatNew { get; set; }
    [Key(29)]
    public string[] SignatureDesc { get; set; }
    [Key(30)]
    public string[] IconTextKey { get; set; }
    [Key(31)]
    public string[] EquipTypeStatTextKey { get; set; }
}
