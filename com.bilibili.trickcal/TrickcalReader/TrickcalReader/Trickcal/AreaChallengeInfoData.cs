using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AreaChallengeInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int WorldUid { get; set; }
    [Key(2)]
    public int InteractionUid { get; set; }
    [Key(3)]
    public ContentsUnlockType UnlockType { get; set; }
    [Key(4)]
    public int UnlockValue { get; set; }
    [Key(5)]
    public int ChallengeOpenDelayHours { get; set; }
    [Key(6)]
    public int ChallengeCloseDelayHours { get; set; }
    [Key(7)]
    public int HeroUid { get; set; }
    [Key(8)]
    public int BeforeInteractionUid { get; set; }
    [Key(9)]
    public int AfterInteractionUid { get; set; }
    [Key(10)]
    public int WinInteractionUid { get; set; }
    [Key(11)]
    public int LoseInteractionUid { get; set; }
    [Key(12)]
    public StatType[] StatusVisible { get; set; }
}
