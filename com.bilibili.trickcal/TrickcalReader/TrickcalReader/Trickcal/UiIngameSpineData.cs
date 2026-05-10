using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UiIngameSpineData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string SpineName { get; set; }
    [Key(2)]
    public float CardPosX { get; set; }
    [Key(3)]
    public float CardPosY { get; set; }
    [Key(4)]
    public float CardScale { get; set; }
    [Key(5)]
    public float StartPickPosX { get; set; }
    [Key(6)]
    public float StartPickPosY { get; set; }
    [Key(7)]
    public Pos CardPos { get; set; }
    [Key(8)]
    public Pos StartPickPos { get; set; }
    [Key(9)]
    public float UpgradeResultScale { get; set; }
    [Key(10)]
    public float UpgradeResultPosX { get; set; }
    [Key(11)]
    public float UpgradeResultPosY { get; set; }
}
