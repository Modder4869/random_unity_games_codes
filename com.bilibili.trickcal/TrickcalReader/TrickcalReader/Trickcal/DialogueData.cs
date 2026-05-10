using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DialogueData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int EpisodeUid { get; set; }
    [Key(2)]
    public int NextEvent { get; set; }
    [Key(3)]
    public DialogueEventType DialogueEventType { get; set; }
    [Key(4)]
    public int Sender { get; set; }
    [Key(5)]
    public string SenderName { get; set; }
    [Key(6)]
    public TextType TextType { get; set; }
    [Key(7)]
    public TextSize TextSize { get; set; }
    [Key(8)]
    public float TextSpeed { get; set; }
    [Key(9)]
    public string TextIndex { get; set; }
    [Key(10)]
    public TextConnect TextConnect { get; set; }
    [Key(11)]
    public int BubbleUid { get; set; }
    [Key(12)]
    public BubbleMove BubbleMove { get; set; }
    [Key(13)]
    public int BubbleTail { get; set; }
    [Key(14)]
    public string[] BG { get; set; }
    [Key(15)]
    public CGType CGType { get; set; }
    [Key(16)]
    public string CG { get; set; }
    [Key(17)]
    public CameraType[] CameraType { get; set; }
    [Key(18)]
    public float[] CameraX { get; set; }
    [Key(19)]
    public float[] CameraY { get; set; }
    [Key(20)]
    public float[] CameraTime { get; set; }
    [Key(21)]
    public Transition Transition { get; set; }
    [Key(22)]
    public FilterType[] FilterType { get; set; }
    [Key(23)]
    public string[] Filter { get; set; }
    [Key(24)]
    public int[] EffectUid { get; set; }
    [Key(25)]
    public int[] EmoticonUid { get; set; }
    [Key(26)]
    public string BGM { get; set; }
    [Key(27)]
    public float BGMFadeTime { get; set; }
    [Key(28)]
    public string[] SFX { get; set; }
    [Key(29)]
    public int[] SFXLoop { get; set; }
    [Key(30)]
    public string Reaction { get; set; }
    [Key(31)]
    public string Voice { get; set; }
    [Key(32)]
    public int[] Branchs { get; set; }
    [Key(33)]
    public string[] BranchTexts { get; set; }
    [Key(34)]
    public DialogueAffinityType[] BranchAffinities { get; set; }
    [Key(35)]
    public int HiddenEvent { get; set; }
    [Key(36)]
    public string NameTagAni { get; set; }
    [Key(37)]
    public string SpecialEvent { get; set; }
    [Key(38)]
    public float TransitionTime { get; set; }
    [Key(39)]
    public float[] CameraDelay { get; set; }
    [Key(40)]
    public float AutoDelay { get; set; }
    [Key(41)]
    public BGType[] BGType { get; set; }
    [Key(42)]
    public string CGAnimation { get; set; }
    [Key(43)]
    public DialogueForceAutoType ForceAuto { get; set; }
    [Key(44)]
    public float[] SFXDelay { get; set; }
    [Key(45)]
    public float TextLinePadding { get; set; }
    [Key(46)]
    public float[] EffectPosX { get; set; }
    [Key(47)]
    public float[] EffectPosY { get; set; }
    [Key(48)]
    public bool[] EffectLoop { get; set; }
    [Key(49)]
    public float[] EffectDelay { get; set; }
    [Key(50)]
    public float[] EmoticonPosX { get; set; }
    [Key(51)]
    public float[] EmoticonPosY { get; set; }
    [Key(52)]
    public float[] EmoticonDelay { get; set; }
}
