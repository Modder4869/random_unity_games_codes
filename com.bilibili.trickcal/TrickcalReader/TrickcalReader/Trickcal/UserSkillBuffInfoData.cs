using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UserSkillBuffInfoData : TableItem<TableData> {
    [Key(0)]
    public UserSkillGrowthType Type { get; set; }
    [Key(1)]
    public string Icon { get; set; }
    [Key(2)]
    public string Desc { get; set; }
    [Key(3)]
    public bool IsPercent { get; set; }
}
