using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEarlyOpenRerun {
    [Key(0)]
    public int RerunUid { get; set; }
}
