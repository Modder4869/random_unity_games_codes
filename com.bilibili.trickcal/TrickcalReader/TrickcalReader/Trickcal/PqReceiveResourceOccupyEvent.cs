using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveResourceOccupyEvent {
    [Key(0)]
    public int MixedEventUid { get; set; }
}
