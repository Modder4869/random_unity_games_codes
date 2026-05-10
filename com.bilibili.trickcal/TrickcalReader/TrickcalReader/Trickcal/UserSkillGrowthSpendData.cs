using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UserSkillGrowthSpendData : TableItem<TableData> {
    [Key(0)]
    public int GroupUid { get; set; }
    [Key(1)]
    public int Uid { get; set; }
    [Key(2)]
    public int Level { get; set; }
    [Key(3)]
    public int NeedItemUid { get; set; }
    [Key(4)]
    public int NeedItemValue { get; set; }
    [Key(5)]
    public string[] DescParam { get; set; }
}
