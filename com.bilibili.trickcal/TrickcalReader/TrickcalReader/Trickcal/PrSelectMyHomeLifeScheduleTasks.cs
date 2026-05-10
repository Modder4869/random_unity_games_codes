using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrSelectMyHomeLifeScheduleTasks {
    [Key(0)]
    public MyHomeLifeTaskResult[] Results { get; set; }
}
