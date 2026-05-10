using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SkinSetEventData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string TitleText { get; set; }
    [Key(2)]
    public string BackGround { get; set; }
    [Key(3)]
    public string TitleImage { get; set; }
    [Key(4)]
    public int ChapterUid { get; set; }
    [Key(5)]
    public int GachaUid { get; set; }
    [Key(6)]
    public string Bgm { get; set; }
    [Key(7)]
    public string PeriodColor { get; set; }
    [Key(8)]
    public string Spine { get; set; }
}
