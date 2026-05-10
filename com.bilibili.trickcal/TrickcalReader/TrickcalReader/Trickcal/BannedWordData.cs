using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class BannedWordData : TableItem<TableData> {
    [Key(0)]
    public string Word { get; set; }
}
