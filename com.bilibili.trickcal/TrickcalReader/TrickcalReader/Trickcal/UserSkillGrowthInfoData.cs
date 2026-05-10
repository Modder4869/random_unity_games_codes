using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UserSkillGrowthInfoData : TableItem<TableData> {
    [Key(0)]
    public int GroupUid { get; set; }
    [Key(1)]
    public int Uid { get; set; }
    [Key(2)]
    public string Name { get; set; }
    [Key(3)]
    public string Desc { get; set; }
}
