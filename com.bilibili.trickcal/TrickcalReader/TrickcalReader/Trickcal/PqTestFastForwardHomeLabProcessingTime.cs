using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestFastForwardHomeLabProcessingTime {
    [Key(0)]
    public TimeSpan TimeSpan { get; set; }
}
