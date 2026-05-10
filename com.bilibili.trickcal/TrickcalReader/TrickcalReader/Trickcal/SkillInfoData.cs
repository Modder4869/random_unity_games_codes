using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SkillInfoData : TableItem<TableData> {
    [Key(0)]
    public int SkillUid { get; set; }
    [Key(1)]
    public int SkillLevel { get; set; }
    [Key(2)]
    public float[] Param { get; set; }
}
