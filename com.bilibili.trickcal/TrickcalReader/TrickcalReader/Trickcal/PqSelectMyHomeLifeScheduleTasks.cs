using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSelectMyHomeLifeScheduleTasks {
    [Key(0)]
    public int[] TaskIds { get; set; }
}
