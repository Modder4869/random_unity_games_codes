using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TutorialData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int NextUid { get; set; }
    [Key(2)]
    public int SkipUid { get; set; }
    [Key(3)]
    public TutorialType Type { get; set; }
    [Key(4)]
    public int TypeValue { get; set; }
    [Key(5)]
    public TutorialStartCodition StartCondition { get; set; }
    [Key(6)]
    public string StartValue { get; set; }
    [Key(7)]
    public TutorialBubblePos BubblePos { get; set; }
    [Key(8)]
    public int Character { get; set; }
    [Key(9)]
    public bool Flip { get; set; }
    [Key(10)]
    public string Motion { get; set; }
    [Key(11)]
    public string Text { get; set; }
    [Key(12)]
    public int Drop { get; set; }
    [Key(13)]
    public bool SavePoint { get; set; }
    [Key(14)]
    public int[] HelpUids { get; set; }
    [Key(15)]
    public string Voice { get; set; }
    [Key(16)]
    public string SFX { get; set; }
    [Key(17)]
    public int SFXLoop { get; set; }
    [Key(18)]
    public string Token { get; set; }
    [Key(19)]
    public TutorialSkipBtnPosType SkipButtonPos { get; set; }
    [Key(20)]
    public string SkinName { get; set; }
    [Key(21)]
    public int SkipDrop { get; set; }
    [Key(22)]
    public string SkipSummary { get; set; }
}
