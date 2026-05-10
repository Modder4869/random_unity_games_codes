using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class BattleEnvironmentInfo {
    [Key(0)]
    public bool NeedValidationInfo { get; set; }
    [Key(1)]
    public int RandomSeed { get; set; }
}
