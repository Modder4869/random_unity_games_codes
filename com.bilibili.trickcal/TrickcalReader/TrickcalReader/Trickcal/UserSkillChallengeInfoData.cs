using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UserSkillChallengeInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int WorldUid { get; set; }
    [Key(2)]
    public int UserSkillGroupUid { get; set; }
    [Key(3)]
    public int StatBonusHeroGroupUid { get; set; }
    [Key(4)]
    public int InteractionUid { get; set; }
    [Key(5)]
    public ContentsUnlockType UnlockType { get; set; }
    [Key(6)]
    public int UnlockValue { get; set; }
    [Key(7)]
    public int ChallengeOpenDelayHours { get; set; }
    [Key(8)]
    public int ChallengeCloseDelayHours { get; set; }
    [Key(9)]
    public int MaxScore { get; set; }
    [Key(10)]
    public int GimmickInfoUid { get; set; }
    [Key(11)]
    public int StageUid { get; set; }
    [Key(12)]
    public string UserSkillPreset { get; set; }
}
