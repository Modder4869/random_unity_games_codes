using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DefaultItemData : TableItem<TableData> {
    [Key(0)]
    public int GroupUid { get; set; }
    [Key(1)]
    public DefaultItemObtainType ObtainType { get; set; }
    [Key(2)]
    public int ObtainValue { get; set; }
    [Key(3)]
    public RewardType ItemType { get; set; }
    [Key(4)]
    public int ItemUid { get; set; }
    [Key(5)]
    public int ItemValue { get; set; }
}
