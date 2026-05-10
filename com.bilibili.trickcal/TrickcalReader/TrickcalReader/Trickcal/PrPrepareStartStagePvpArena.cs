using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrPrepareStartStagePvpArena {
    [Key(0)]
    public int StagePlayKey { get; set; }
    [Key(1)]
    public PvpArenaUserData PvpArenaUserData { get; set; }
    [Key(2)]
    public DateTime StartTime { get; set; }
}
