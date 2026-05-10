using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HeroVoiceData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int HeroUid { get; set; }
    [Key(2)]
    public string StandingSpine { get; set; }
    [Key(3)]
    public ContentsUnlockType UnlockType { get; set; }
    [Key(4)]
    public int UnlockValue { get; set; }
    [Key(5)]
    public string Sound { get; set; }
    [Key(6)]
    public string Dialogue { get; set; }
    [Key(7)]
    public string VoiceTitle { get; set; }
    [Key(8)]
    public int[] TitleValue { get; set; }
    [Key(9)]
    public int UnlockValueExtra { get; set; }
    [Key(10)]
    public AlbumVoiceTabType VoiceTab { get; set; }
    [Key(11)]
    public int HeroAffinityReactionUid { get; set; }
}
