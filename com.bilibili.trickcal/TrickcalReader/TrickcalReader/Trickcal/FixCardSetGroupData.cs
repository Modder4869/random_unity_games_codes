using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class FixCardSetGroupData : TableItem<TableData> {
    [Key(0)]
    public int GroupUid { get; set; }
    [Key(1)]
    public int CardUid { get; set; }
    [Key(2)]
    public int CardLevel { get; set; }
}
