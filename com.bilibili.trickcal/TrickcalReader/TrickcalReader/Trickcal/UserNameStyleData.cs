using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UserNameStyleData : TableItem<TableData> {
    [Key(0)]
    public TableBaseItemData ItemData { get; set; }
    [Key(1)]
    public int GroupId { get; set; }
    [Key(3)]
    public int Filter { get; set; }
    [Key(4)]
    public int Sort { get; set; }
    [Key(5)]
    public UserNameTextType TextType { get; set; }
    [Key(6)]
    public string EffectName { get; set; }
    [Key(7)]
    public string ObtainDesc { get; set; }
    [Key(8)]
    public string Prefab { get; set; }
}
