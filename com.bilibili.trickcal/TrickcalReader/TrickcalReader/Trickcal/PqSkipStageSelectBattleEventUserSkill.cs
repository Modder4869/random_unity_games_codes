using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSkipStageSelectBattleEventUserSkill {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int SelectBattleEventUid { get; set; }
    [Key(2)]
    public int StageUid { get; set; }
    [Key(3)]
    public int SkipCount { get; set; }
}
