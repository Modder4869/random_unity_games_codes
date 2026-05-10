using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MiniGameInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public MiniGameType Type { get; set; }
    [Key(2)]
    public int HelpUid { get; set; }
    [Key(3)]
    public string TitleText { get; set; }
    [Key(4)]
    public string TitleImage { get; set; }
    [Key(5)]
    public string BackgroundSpine { get; set; }
    [Key(6)]
    public string LobbyBGM { get; set; }
    [Key(7)]
    public ContentsUnlockType ArcadeUnlockType { get; set; }
    [Key(8)]
    public int ArcadeUnlockValue { get; set; }
    [Key(9)]
    public string[] TabNames { get; set; }
    [Key(10)]
    public int[] GroupUids { get; set; }
    [Key(11)]
    public int[] InteractionUids { get; set; }
    [Key(12)]
    public bool[] IsVisibles { get; set; }
    [Key(13)]
    public bool IsArcade { get; set; }
    [Key(14)]
    public int MaxScore { get; set; }
    [Key(15)]
    public string ListImage { get; set; }
    [Key(16)]
    public string TopScoreTitle { get; set; }
    [Key(17)]
    public string TextColor { get; set; }
    [Key(18)]
    public string BaseColor { get; set; }
}
