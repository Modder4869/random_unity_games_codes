using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UserLvPassGroupData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public string TabName { get; set; }
}
