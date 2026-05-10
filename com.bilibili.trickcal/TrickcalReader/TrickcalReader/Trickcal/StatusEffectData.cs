using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StatusEffectData : TableItem<TableData> {
    [Key(0)]
    public int UId { get; set; }
    [Key(1)]
    public StatusEffect Key { get; set; }
    [Key(2)]
    public StatusEffectType Type { get; set; }
    [Key(3)]
    public ApplyType ApplyType { get; set; }
    [Key(4)]
    public BuffType BuffType { get; set; }
    [Key(5)]
    public bool Removable { get; set; }
    [Key(6)]
    public bool RemainEffect { get; set; }
    [Key(7)]
    public int StackCount { get; set; }
    [Key(8)]
    public bool TimeExtension { get; set; }
    [Key(9)]
    public int ShowPriorities { get; set; }
    [Key(10)]
    public string Icon { get; set; }
    [Key(11)]
    public string IconArtifact { get; set; }
    [Key(12)]
    public float[] ParamArray { get; set; }
    [Key(13)]
    public string Name { get; set; }
    [Key(14)]
    public bool DescOutput { get; set; }
    [Key(15)]
    public string Desc { get; set; }
    [Key(16)]
    public string Effect { get; set; }
    [Key(17)]
    public string TargetBone { get; set; }
    [Key(18)]
    public bool FollowTargetBone { get; set; }
    [Key(19)]
    public OverlapType OverlapType { get; set; }
    [Key(20)]
    public bool ShowLeftTime { get; set; }
}
