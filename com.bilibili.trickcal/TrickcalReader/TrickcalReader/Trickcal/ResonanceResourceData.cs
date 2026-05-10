using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ResonanceResourceData : TableItem<TableData> {
    [Key(0)]
    public int UnitUid { get; set; }
    [Key(1)]
    public PersonalityType Personality { get; set; }
    [Key(2)]
    public int BasicAttackUid { get; set; }
    [Key(3)]
    public int SPSkillUid { get; set; }
    [Key(4)]
    public int UltimateUid { get; set; }
    [Key(5)]
    public string Voice { get; set; }
    [Key(6)]
    public string PersonalitySelectEffectSlotName { get; set; }
    [Key(7)]
    public string PersonalitySelectUIEffect { get; set; }
    [Key(8)]
    public string PersonalitySelectMotion { get; set; }
    [Key(9)]
    public string FrontStandingEffectSlotName { get; set; }
    [Key(10)]
    public string FrontStandingEffectUIName { get; set; }
    [Key(11)]
    public string FrontStandingEffect3DName { get; set; }
    [Key(12)]
    public string BackStandingEffectSlotName { get; set; }
    [Key(13)]
    public string BackStandingEffectUIName { get; set; }
    [Key(14)]
    public string BackStandingEffect3DName { get; set; }
    [Key(15)]
    public string IngameEffectSlotName { get; set; }
    [Key(16)]
    public string IngameEffectUIName { get; set; }
    [Key(17)]
    public string IngameEffect3DName { get; set; }
}
