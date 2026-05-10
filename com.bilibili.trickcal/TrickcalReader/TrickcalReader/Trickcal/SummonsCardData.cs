using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SummonsCardData : TableItem<TableData> {
    [Key(0)]
    public TableBaseItemData ItemData { get; set; }
    [Key(1)]
    public SummonsCardType Type { get; set; }
    [Key(2)]
    public int Grade { get; set; }
    [Key(3)]
    public int FusionProb { get; set; }
    [Key(4)]
    public int UseNum { get; set; }
    [Key(5)]
    public int Drop { get; set; }
    [Key(6)]
    public int SummonsCardPoint { get; set; }
}
