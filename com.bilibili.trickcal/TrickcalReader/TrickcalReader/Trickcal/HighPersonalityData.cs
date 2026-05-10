using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HighPersonalityData : TableItem<TableData> {
    [Key(0)]
    public string Uid { get; set; }
    [Key(1)]
    public HighPersonalityType HighPersonalityType { get; set; }
    [Key(2)]
    public PersonalityType BasePersonalityType { get; set; }
    [Key(3)]
    public string HighPersonalityName { get; set; }
    [Key(4)]
    public string HighPersonalityDesc { get; set; }
    [Key(5)]
    public string PersonalityIcon { get; set; }
    [Key(6)]
    public string PersonalityIconEffect { get; set; }
    [Key(7)]
    public string[] BonusStatusEffects { get; set; }
    [Key(8)]
    public int[] BonusStatusEffectValues { get; set; }
}
