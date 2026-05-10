using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class BoardData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int HeroInfoUid { get; set; }
    [Key(2)]
    public int Step { get; set; }
    [Key(3)]
    public BoardNodeType NodeType { get; set; }
    [Key(4)]
    public OutGameStatType[] StatType { get; set; }
    [Key(5)]
    public float[] StatValue { get; set; }
    [Key(6)]
    public int NeedGold { get; set; }
    [Key(7)]
    public int[] NeedItemIds { get; set; }
    [Key(8)]
    public int[] NeedItemValues { get; set; }
    [Key(9)]
    public int NodeGridX { get; set; }
    [Key(10)]
    public int NodeGridY { get; set; }
    [Key(11)]
    public HashSet<int> Links { get; set; }
}
