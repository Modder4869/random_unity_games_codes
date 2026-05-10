using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class RecordTypeData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public RecordType RecordType { get; set; }
    [Key(2)]
    public int Sort { get; set; }
    [Key(3)]
    public string Name { get; set; }
}
