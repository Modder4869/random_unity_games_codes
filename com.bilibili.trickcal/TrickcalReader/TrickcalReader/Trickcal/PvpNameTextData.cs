using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PvpNameTextData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int WordType { get; set; }
    [Key(2)]
    public string Text { get; set; }
}
