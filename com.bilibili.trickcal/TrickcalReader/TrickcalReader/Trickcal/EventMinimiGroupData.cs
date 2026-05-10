using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class EventMinimiGroupData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int[] Units { get; set; }
    [Key(2)]
    public string[] SkinKeys { get; set; }
    [Key(3)]
    public string[] Motions { get; set; }
}
