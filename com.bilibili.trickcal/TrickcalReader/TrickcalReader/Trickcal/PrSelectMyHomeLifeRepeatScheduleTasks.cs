using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrSelectMyHomeLifeRepeatScheduleTasks {
    [Key(0)]
    public List<MyHomeLifeTaskResult[]> Results { get; set; }
}
