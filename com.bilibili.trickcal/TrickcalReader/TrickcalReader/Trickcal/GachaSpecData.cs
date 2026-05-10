using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GachaSpecData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public bool IsUse { get; set; }
    [Key(2)]
    public int[] Items { get; set; }
    [Key(3)]
    public int[] DropRatios { get; set; }
}
