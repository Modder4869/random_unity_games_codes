using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MixedEventData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(2)]
    public int[] LotteryEventUids { get; set; }
    [Key(3)]
    public int ShopEventGroupUid { get; set; }
    [Key(4)]
    public int GlobalBattleEventUid { get; set; }
    [Key(5)]
    public int EventQuestGroupUid { get; set; }
    [Key(6)]
    public int LobbyUid { get; set; }
    [Key(7)]
    public int HelpUid { get; set; }
    [Key(8)]
    public int PickupHeroId { get; set; }
    [Key(9)]
    public int ChapterUid { get; set; }
    [Key(10)]
    public int MiniGameUid { get; set; }
    [Key(11)]
    public ContentsUnlockType MiniGameUnlockType { get; set; }
    [Key(12)]
    public int MiniGameUnlockValue { get; set; }
    [Key(13)]
    public int SelectBattleEventUid { get; set; }
    [Key(14)]
    public int PreviewUid { get; set; }
    [Key(15)]
    public int PointEventGroupUid { get; set; }
    [Key(16)]
    public int ResourceOccupyEventGroupUid { get; set; }
    [Key(17)]
    public int AugmentChallengeUid { get; set; }
    [Key(18)]
    public int HardOpenDelayHours { get; set; }
    [Key(19)]
    public int VeryHardOpenDelayHours { get; set; }
    [Key(20)]
    public int ChallengeOpenDelayHours { get; set; }
    [Key(23)]
    public int LobbyStepGroupUid { get; set; }
    [Key(25)]
    public int EventUnitGroupUid { get; set; }
    [Key(26)]
    public int UserSkillChallengeUid { get; set; }
    [Key(28)]
    public int MiniGameOpenDelayHours { get; set; }
    [Key(29)]
    public int PointConsumeEventGroupUid { get; set; }
    [Key(30)]
    public SubContentsType[] SubContentsTypes { get; set; }
    [Key(31)]
    public int[] SubContentsValues { get; set; }
    [Key(32)]
    public bool SkipEventMain { get; set; }
    [Key(33)]
    public string BattleAuthorityName { get; set; }
    [Key(34)]
    public int CardEditGroupId { get; set; }
    [Key(35)]
    public int LobbyInfoUid { get; set; }
    [Key(36)]
    public int AreaChallengeUid { get; set; }
    [Key(37)]
    public int ThemePassUid { get; set; }
    [Key(38)]
    public int LobbyInteractionGroupUid { get; set; }
}
