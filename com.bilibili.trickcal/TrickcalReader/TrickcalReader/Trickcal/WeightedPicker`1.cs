using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WeightedPicker<T> {
    [Key(0)]
    public List<WeightedPickerItem<T>> Items { get; set; }
}
