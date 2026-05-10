using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ItemSpellData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Cost { get; set; }
    [Key(2)]
    public int SelectRate { get; set; }
    [Key(3)]
    public bool Repetition { get; set; }
    [Key(4)]
    public DrawCardConditionType DrawCardCondition { get; set; }
    [Key(5)]
    public int ConditionValue { get; set; }
    [Key(6)]
    public string Icon { get; set; }
    [Key(7)]
    public string SpellItemAction { get; set; }
    [Key(8)]
    public StatusEffect[] EquipTypeStat { get; set; }
    [Key(9)]
    public string[] EquipStatIcon { get; set; }
    [Key(10)]
    public string Desc { get; set; }
    [Key(11)]
    public string Detail { get; set; }
    [Key(12)]
    public int DrawConditionUid { get; set; }
    [Key(13)]
    public TableBaseCardData CardData { get; set; }
    [Key(14)]
    public int Tier { get; set; }
    [Key(15)]
    public string EffectDesc { get; set; }
    [Key(16)]
    public bool Available { get; set; }
    [Key(17)]
    public string[] EquipTypeStatNew { get; set; }
    [Key(18)]
    public int SignatureCardHeroUid { get; set; }
    [Key(19)]
    public int SignatureCardUid { get; set; }
    [Key(20)]
    public string[] IconTextKey { get; set; }
    [Key(21)]
    public string[] EquipTypeStatTextKey { get; set; }
}
