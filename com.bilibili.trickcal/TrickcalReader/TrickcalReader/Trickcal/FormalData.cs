using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class FormalData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public double ValueA { get; set; }
    [Key(2)]
    public double ValueB { get; set; }
    [Key(3)]
    public double ValueC { get; set; }
    [Key(4)]
    public double ValueD { get; set; }
    [Key(5)]
    public double ValueMin { get; set; }
    [Key(6)]
    public double ValueMax { get; set; }
    [Key(7)]
    public bool MaxValueInfinite { get; set; }
    [Key(8)]
    public double ValueE { get; set; }
    [Key(9)]
    public double ValueF { get; set; }
}
