using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct HeroReward {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Count { get; set; }
}
