using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserGlobalBattleEventWorldData {
    [Key(0)]
    public int LastClearStageUid { get; set; }
    [Key(1)]
    public StageClearState[] StageStates { get; set; }
    [Key(2)]
    public int[] DeckBonuses { get; set; }
}
