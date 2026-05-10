using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AnniversaryPageData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int[] EventUid { get; set; }
    [Key(2)]
    public int ShopMainCategory { get; set; }
    [Key(3)]
    public string LobbyIcon { get; set; }
    [Key(4)]
    public int StoryUid { get; set; }
    [Key(5)]
    public int[] GachaUid { get; set; }
    [Key(6)]
    public int RecordUid { get; set; }
    [Key(7)]
    public string BG { get; set; }
    [Key(8)]
    public string BGM { get; set; }
    [Key(9)]
    public string[] Effect { get; set; }
    [Key(10)]
    public int[] EffectX { get; set; }
    [Key(11)]
    public int[] EffectY { get; set; }
    [Key(12)]
    public string LobbyEffect { get; set; }
    [Key(13)]
    public string FrontEffect { get; set; }
    [Key(14)]
    public string BackEffect { get; set; }
    [Key(15)]
    public int _ { get; set; }
    [Key(16)]
    public string[] MiniEventQuestTabNames { get; set; }
    [Key(17)]
    public int[] MiniEventQuestGroupIds { get; set; }
    [Key(18)]
    public bool[] MiniEventQuestIsVisibles { get; set; }
    [Key(19)]
    public int[] MiniEventQuestInteractions { get; set; }
    [Key(20)]
    public string MiniEventQuestBg { get; set; }
}
