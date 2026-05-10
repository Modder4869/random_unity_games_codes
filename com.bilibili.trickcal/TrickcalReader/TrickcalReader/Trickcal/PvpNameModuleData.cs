using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PvpNameModuleData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public bool MainType { get; set; }
    [Key(2)]
    public int NameCount { get; set; }
    [Key(3)]
    public int[] WordTypes { get; set; }
    [Key(4)]
    public int WordTypeLength { get; set; }
    [Key(5)]
    public int MaxNameCount { get; set; }
}
