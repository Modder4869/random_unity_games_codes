using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HelpCountData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public short HelpCount { get; set; }
    [Key(2)]
    public int Weight { get; set; }
}
