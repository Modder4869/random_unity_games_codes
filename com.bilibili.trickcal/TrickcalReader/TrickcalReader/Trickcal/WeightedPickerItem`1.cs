using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct WeightedPickerItem<T> {
    [Key(0)]
    public T Item { get; set; }
    [Key(1)]
    public int Weight { get; set; }
}
