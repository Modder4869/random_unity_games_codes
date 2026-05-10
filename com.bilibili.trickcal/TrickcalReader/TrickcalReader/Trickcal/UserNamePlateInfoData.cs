using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UserNamePlateInfoData : TableItem<TableData> {
    [Key(0)]
    public TableBaseItemData ItemData { get; set; }
    [Key(1)]
    public string Skin { get; set; }
    [Key(2)]
    public string ObtainDesc { get; set; }
    [Key(3)]
    public int GroupId { get; set; }
    [Key(5)]
    public int UnitUid { get; set; }
    [Key(6)]
    public int Filter { get; set; }
    [Key(7)]
    public int Sort { get; set; }
    [Key(8)]
    public float PlaySpeed { get; set; }
}
