using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ExtraTutorialGroupData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public int NextUid { get; set; }
    [Key(3)]
    public int SkipUid { get; set; }
    [Key(4)]
    public TutorialSkipBtnPosType SkipButtonPos { get; set; }
    [Key(5)]
    public string SkipSummary { get; set; }
    [Key(6)]
    public string Image { get; set; }
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
    public string Voice { get; set; }
    [Key(13)]
    public string SFX { get; set; }
    [Key(14)]
    public int SFXLoop { get; set; }
    [Key(15)]
    public ExtraTutorialTargetType TargetType { get; set; }
    [Key(16)]
    public string TargetRoot { get; set; }
    [Key(17)]
    public string TargetPath { get; set; }
    [Key(18)]
    public float HighlightWidth { get; set; }
    [Key(19)]
    public float HighlightHeight { get; set; }
    [Key(20)]
    public bool KeepBlockScreen { get; set; }
    [Key(21)]
    public float NextDelay { get; set; }
    [Key(22)]
    public ExtraTutorialType Type { get; set; }
    [Key(23)]
    public int TypeValue { get; set; }
    [Key(24)]
    public int HelpUid { get; set; }
    [Key(25)]
    public ExtraTutorialArrowPos ExtraTutorialArrowPos { get; set; }
    [Key(26)]
    public float HighlightScale { get; set; }
    [Key(27)]
    public float StartDelay { get; set; }
    [Key(28)]
    public ExtraTutorialTargetType[] TargetTypes { get; set; }
    [Key(29)]
    public string[] TargetRoots { get; set; }
    [Key(30)]
    public string[] TargetPaths { get; set; }
    [Key(31)]
    public string[] TargetArrows { get; set; }
    [Key(32)]
    public int[] HighlightWidths { get; set; }
    [Key(33)]
    public int[] HighlightHeights { get; set; }
}
