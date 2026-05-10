using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEndTrickcalPass {
    [Key(0)]
    public int EventId { get; set; }
}
