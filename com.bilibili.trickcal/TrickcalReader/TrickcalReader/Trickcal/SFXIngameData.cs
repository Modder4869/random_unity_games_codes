using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SFXIngameData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int SkillUid { get; set; }
    [Key(2)]
    public SoundType SoundType { get; set; }
    [Key(3)]
    public SkillType ActionType { get; set; }
    [Key(4)]
    public string[] SoundPreset { get; set; }
    [Key(5)]
    public SoundCondition Condition { get; set; }
    [Key(6)]
    public string ConditionValue { get; set; }
    [Key(7)]
    public float StartDelay { get; set; }
    [Key(8)]
    public float CoolTime { get; set; }
}
