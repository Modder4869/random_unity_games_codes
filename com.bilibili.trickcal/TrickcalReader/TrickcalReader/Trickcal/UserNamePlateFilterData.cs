using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UserNamePlateFilterData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string Name { get; set; }
}
