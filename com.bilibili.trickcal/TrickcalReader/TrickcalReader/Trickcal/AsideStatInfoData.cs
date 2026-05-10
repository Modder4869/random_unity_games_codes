using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AsideStatInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Grade { get; set; }
    [Key(2)]
    public OutGameStatType[] AllStatType { get; set; }
    [Key(3)]
    public float[] AllStatValue { get; set; }
}
