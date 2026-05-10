using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqStartAccountReturnEvent {
    [Key(0)]
    public int EventId { get; set; }
}
