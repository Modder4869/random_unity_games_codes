using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PetAttributeData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string Name { get; set; }
    [Key(2)]
    public string Icon { get; set; }
}
