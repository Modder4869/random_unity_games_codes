using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqPrepareStartStagePvpArena {
    [Key(0)]
    public int TargetUserId { get; set; }
}
