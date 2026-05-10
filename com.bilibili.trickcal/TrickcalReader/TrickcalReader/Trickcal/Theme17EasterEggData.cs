using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class Theme17EasterEggData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string Name { get; set; }
    [Key(2)]
    public string Desc { get; set; }
    [Key(3)]
    public string Image { get; set; }
    [Key(4)]
    public int TimeValue { get; set; }
    [Key(5)]
    public int TimeValueRange { get; set; }
}
