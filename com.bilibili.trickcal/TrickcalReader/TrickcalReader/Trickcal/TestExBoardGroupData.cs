using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TestExBoardGroupData : TableItem<TableData> {
    [Key(0)]
    public int ExBoardGroupUid { get; set; }
    [Key(1)]
    public int Step { get; set; }
    [Key(2)]
    public OutGameStatType StatType { get; set; }
}
