using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct CustomDropGroupKey {
    [Key(0)]
    public int Group { get; set; }
    [Key(1)]
    public CustomDropGroupType Type { get; set; }
    [Key(2)]
    public int Value { get; set; }
}
