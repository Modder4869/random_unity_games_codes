using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrStartStageChaosArena {
    [Key(0)]
    public BattleEnvironmentInfo BattleEnvironmentInfo { get; set; }
}
