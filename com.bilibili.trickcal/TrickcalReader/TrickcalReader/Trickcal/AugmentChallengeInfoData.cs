using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AugmentChallengeInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int HighAugmentGroup { get; set; }
    [Key(2)]
    public int WorldUid { get; set; }
    [Key(3)]
    public int LevelGroupUid { get; set; }
    [Key(4)]
    public int StatBonusHeroGroupUid { get; set; }
    [Key(5)]
    public int InteractionUid { get; set; }
    [Key(6)]
    public ContentsUnlockType UnlockType { get; set; }
    [Key(7)]
    public int UnlockValue { get; set; }
    [Key(8)]
    public int ChallengeOpenDelayHours { get; set; }
    [Key(9)]
    public int ChallengeCloseDelayHours { get; set; }
    [Key(10)]
    public int MaxScore { get; set; }
    [Key(11)]
    public int EntertainmentUnit { get; set; }
    [Key(12)]
    public string BackgroundLoopText { get; set; }
    [Key(13)]
    public int CardPresetUid { get; set; }
}
