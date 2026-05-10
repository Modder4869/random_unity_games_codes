using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MyHomeIdolSkinData : TableItem<TableData> {
    [Key(0)]
    public TableBaseItemData ItemData { get; set; }
    [Key(2)]
    public int Filter { get; set; }
    [Key(3)]
    public int Sort { get; set; }
    [Key(4)]
    public MyHomeIdolSkinAltarType AltarType { get; set; }
    [Key(5)]
    public string Skin { get; set; }
    [Key(6)]
    public float PlaySpeed { get; set; }
    [Key(7)]
    public string EffectName { get; set; }
    [Key(8)]
    public string ObtainDesc { get; set; }
}
