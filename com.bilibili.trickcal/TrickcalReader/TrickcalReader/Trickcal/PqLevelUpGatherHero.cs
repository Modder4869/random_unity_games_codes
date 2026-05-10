using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqLevelUpGatherHero {
    [Key(0)]
    public Dictionary<GatherStatusType, int> LevelUpGatherHero { get; set; }
}
