using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class BilibiliChainTypeMasterData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Batch { get; set; }
    [Key(2)]
    public int Type { get; set; }
    [Key(3)]
    public int Value { get; set; }
    [Key(4)]
    public string Name { get; set; }
    [Key(5)]
    public int Loop { get; set; }
    [Key(6)]
    public bool IsVisible { get; set; }
    [Key(7)]
    public int EventUid { get; set; }
}
