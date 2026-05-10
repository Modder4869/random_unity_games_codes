using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GachaGetData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public GachaObtainType ObtainType { get; set; }
    [Key(2)]
    public int Grade { get; set; }
    [Key(3)]
    public int Exchange { get; set; }
    [Key(4)]
    public int MinMult { get; set; }
    [Key(5)]
    public int MaxMult { get; set; }
    [Key(6)]
    public int Value { get; set; }
}
