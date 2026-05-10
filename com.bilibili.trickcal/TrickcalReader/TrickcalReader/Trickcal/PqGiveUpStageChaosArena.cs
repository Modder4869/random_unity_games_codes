using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqGiveUpStageChaosArena {
    [Key(0)]
    public int StagePlayKey { get; set; }
}
