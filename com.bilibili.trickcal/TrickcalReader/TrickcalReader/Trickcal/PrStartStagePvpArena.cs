using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrStartStagePvpArena {
    [Key(0)]
    public BattleEnvironmentInfo BattleEnvironmentInfo { get; set; }
}
