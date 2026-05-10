using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEndDropEvent {
    [Key(0)]
    public int DropEventUid { get; set; }
}
