using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StartSlotPickData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int[] NextHeroPick { get; set; }
}
