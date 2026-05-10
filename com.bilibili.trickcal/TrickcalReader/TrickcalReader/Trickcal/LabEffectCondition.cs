using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct LabEffectCondition {
    [Key(0)]
    public LabEffectType Type { get; set; }
    [Key(1)]
    public int Value { get; set; }
}
