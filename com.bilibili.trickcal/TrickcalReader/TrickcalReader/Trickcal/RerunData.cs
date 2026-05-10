using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class RerunData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public EventType EventType { get; set; }
    [Key(2)]
    public int EventUid { get; set; }
    [Key(3)]
    public bool Active { get; set; }
    [Key(5)]
    public int WorldUid { get; set; }
    [Key(6)]
    public int OpenStageUid { get; set; }
    [Key(7)]
    public int HardOpenStageUid { get; set; }
    [Key(8)]
    public int VeryHardOpenStageUid { get; set; }
    [Key(9)]
    public int ChallengeOpenStageUid { get; set; }
    [Key(10)]
    public string Category { get; set; }
    [Key(11)]
    public EpisodeUnlockType[] UnlockTypes { get; set; }
    [Key(12)]
    public int[] UnlockValues { get; set; }
    [Key(13)]
    public string StoryButton { get; set; }
    [Key(14)]
    public string BattleButton { get; set; }
    [Key(15)]
    public string ChallengeButton { get; set; }
    [Key(16)]
    public bool BackgroundHighlight { get; set; }
}
