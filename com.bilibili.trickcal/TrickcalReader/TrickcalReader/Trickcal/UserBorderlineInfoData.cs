using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UserBorderlineInfoData : TableItem<TableData> {
    [Key(0)]
    public TableBaseItemData ItemData { get; set; }
    [Key(1)]
    public int Sort { get; set; }
    [Key(2)]
    public int GroupId { get; set; }
    [Key(3)]
    public string Spine { get; set; }
    [Key(4)]
    public string Effect { get; set; }
    [Key(6)]
    public int Filter { get; set; }
}
