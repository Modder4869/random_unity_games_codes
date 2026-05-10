using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UiTitleData : TableItem<TableData> {
    [Key(0)]
    public int UId { get; set; }
    [Key(1)]
    public string TitleAni1 { get; set; }
    [Key(2)]
    public string TitleAni2 { get; set; }
    [Key(3)]
    public bool TitleAppear { get; set; }
    [Key(4)]
    public int TitleAppearRatio { get; set; }
    [Key(5)]
    public int HeroUid { get; set; }
    [Key(6)]
    public string SkinKey { get; set; }
    [Key(7)]
    public float TitleHeroScale { get; set; }
}
