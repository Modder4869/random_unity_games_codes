using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UserProfileInfoData : TableItem<TableData> {
    [Key(0)]
    public TableBaseItemData ItemData { get; set; }
    [Key(1)]
    public int Sort { get; set; }
    [Key(2)]
    public string Effect { get; set; }
    [Key(3)]
    public int GroupId { get; set; }
    [Key(5)]
    public int UnitUid { get; set; }
}
