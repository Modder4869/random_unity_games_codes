using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqMatchTimeoutPvpArena {
    [Key(0)]
    public int StagePlayKey { get; set; }
}
