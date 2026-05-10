using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HeroLoveData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public StatType StatType { get; set; }
    [Key(2)]
    public int Value { get; set; }
    [Key(3)]
    public int Grade { get; set; }
}
