using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CommentGroupData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public string Icon { get; set; }
    [Key(3)]
    public string NickName { get; set; }
    [Key(4)]
    public string Desc { get; set; }
}
