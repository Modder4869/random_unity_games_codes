using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SlotContentsValueData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int[] Param { get; set; }
    [Key(2)]
    public string[] ParamNew { get; set; }
}
