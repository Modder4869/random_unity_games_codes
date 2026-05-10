using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class Theme17UnitInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string Spine { get; set; }
    [Key(2)]
    public string Text1 { get; set; }
    [Key(3)]
    public int Ratio1 { get; set; }
    [Key(4)]
    public string Text2 { get; set; }
    [Key(5)]
    public int Ratio2 { get; set; }
}
