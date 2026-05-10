using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TestSkipValidationEvent {
    [Key(0)]
    public int EventIndex { get; set; }
    [Key(1)]
    public TimeSpan ElapsedTime { get; set; }
    [Key(2)]
    public int RandomCountStart { get; set; }
}
