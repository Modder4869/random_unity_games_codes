using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SlotContentGroupData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int SlotContentsUid { get; set; }
    [Key(2)]
    public int GroupID { get; set; }
}
