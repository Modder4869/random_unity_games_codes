using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CookingTycoonInteractionData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int ContentsUid { get; set; }
    [Key(2)]
    public int HeroUid { get; set; }
    [Key(3)]
    public string PerfectText { get; set; }
    [Key(4)]
    public string PerfectAni { get; set; }
    [Key(5)]
    public string GoodText { get; set; }
    [Key(6)]
    public string GoodAni { get; set; }
    [Key(7)]
    public string NormalText { get; set; }
    [Key(8)]
    public string NormalAni { get; set; }
    [Key(9)]
    public string BadText { get; set; }
    [Key(10)]
    public string BadAni { get; set; }
    [Key(11)]
    public float PerfectAni_PosX { get; set; }
    [Key(12)]
    public float GoodAni_PosX { get; set; }
    [Key(13)]
    public float NormalAni_PosX { get; set; }
    [Key(14)]
    public float BadAni_PosX { get; set; }
    [Key(15)]
    public string Skin { get; set; }
    [Key(16)]
    public float PerfectAni_PosY { get; set; }
    [Key(17)]
    public float GoodAni_PosY { get; set; }
    [Key(18)]
    public float NormalAni_PosY { get; set; }
    [Key(19)]
    public float BadAni_PosY { get; set; }
}
