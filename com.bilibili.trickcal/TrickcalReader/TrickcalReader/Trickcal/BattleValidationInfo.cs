using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class BattleValidationInfo {
    [Key(0)]
    public int StageUid { get; set; }
    [Key(1)]
    public int RandomSeed { get; set; }
    [Key(3)]
    public List<BattleEventGroup> BattleEventGroups { get; set; }
}
