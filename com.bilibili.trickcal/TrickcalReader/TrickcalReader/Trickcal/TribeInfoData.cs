using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TribeInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public TribeType TribeType { get; set; }
    [Key(2)]
    public string Name { get; set; }
    [Key(3)]
    public string Icon { get; set; }
}
