using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ResourceOccupyEventData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public int GenerateCondition { get; set; }
    [Key(3)]
    public int GenerateValue { get; set; }
    [Key(4)]
    public int GenerateGoodsId { get; set; }
    [Key(5)]
    public int GenerateLimit { get; set; }
}
