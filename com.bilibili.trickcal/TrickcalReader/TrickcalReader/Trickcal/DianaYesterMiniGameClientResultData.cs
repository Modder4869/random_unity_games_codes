using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DianaYesterMiniGameClientResultData {
    [Key(0)]
    public int StageUid { get; set; }
    [Key(1)]
    public int Score { get; set; }
    [Key(2)]
    public TimeSpan PlayTime { get; set; }
    [Key(3)]
    public List<IDianaYesterMiniGameEvent> Events { get; set; }
}
