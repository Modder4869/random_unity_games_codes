using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CookingTycoonOrderStandingData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int HeroUid { get; set; }
    [Key(2)]
    public string Skin { get; set; }
    [Key(3)]
    public string OrderText { get; set; }
    [Key(4)]
    public string OrderAni { get; set; }
    [Key(5)]
    public float OrderAni_PosX { get; set; }
    [Key(6)]
    public string ReOrderText { get; set; }
    [Key(7)]
    public string ReOrderAni { get; set; }
    [Key(8)]
    public float ReOrderAni_PosX { get; set; }
    [Key(9)]
    public float OrderAni_PosY { get; set; }
    [Key(10)]
    public float ReOrderAni_PosY { get; set; }
}
