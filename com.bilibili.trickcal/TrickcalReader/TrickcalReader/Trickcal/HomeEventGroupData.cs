using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HomeEventGroupData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public int StartGroup { get; set; }
    [Key(3)]
    public int SuccessGroup { get; set; }
    [Key(4)]
    public int FailGroup { get; set; }
    [Key(5)]
    public int RemainMinute { get; set; }
}
