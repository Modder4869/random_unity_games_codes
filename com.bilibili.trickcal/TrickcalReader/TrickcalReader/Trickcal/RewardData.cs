using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct RewardData {
    [Key(0)]
    public RewardType Type { get; set; }
    [Key(1)]
    public int Uid { get; set; }
    [Key(2)]
    public int Value { get; set; }
}
