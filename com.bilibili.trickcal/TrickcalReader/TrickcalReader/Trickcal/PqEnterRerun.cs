using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEnterRerun {
    [Key(0)]
    public int RerunUid { get; set; }
}
