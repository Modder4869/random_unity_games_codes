using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqDropRatio {
    [Key(0)]
    public int[] DropIds { get; set; }
}
