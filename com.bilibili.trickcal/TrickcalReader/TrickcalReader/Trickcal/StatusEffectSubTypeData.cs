using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StatusEffectSubTypeData : TableItem<TableData> {
    [Key(0)]
    public string Uid { get; set; }
    [Key(1)]
    public StatusEffectTypeNew Type { get; set; }
    [Key(2)]
    public string[] Param { get; set; }
    [Key(3)]
    public string Effect { get; set; }
    [Key(4)]
    public string TargetBone { get; set; }
    [Key(5)]
    public bool FollowTargetBone { get; set; }
}
