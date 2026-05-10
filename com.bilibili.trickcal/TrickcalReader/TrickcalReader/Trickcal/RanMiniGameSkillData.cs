using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class RanMiniGameSkillData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public RanMiniGameSkillType Type { get; set; }
    [Key(2)]
    public float Time { get; set; }
    [Key(3)]
    public RanMiniGameSkillTargetType TargetType { get; set; }
    [Key(4)]
    public int TriggerValue { get; set; }
    [Key(5)]
    public string[] Params { get; set; }
}
