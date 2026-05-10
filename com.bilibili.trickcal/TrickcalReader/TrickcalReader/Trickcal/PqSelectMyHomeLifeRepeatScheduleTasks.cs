using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSelectMyHomeLifeRepeatScheduleTasks {
    [Key(0)]
    public int[] TaskIds { get; set; }
    [Key(1)]
    public int RepeatCount { get; set; }
}
