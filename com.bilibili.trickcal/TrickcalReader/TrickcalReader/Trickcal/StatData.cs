using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StatData {
    [Key(0)]
    public Dictionary<StatType, float> StatList { get; set; }
    [Key(1)]
    public Dictionary<StatType, float> IncreaseStatList { get; set; }
}
