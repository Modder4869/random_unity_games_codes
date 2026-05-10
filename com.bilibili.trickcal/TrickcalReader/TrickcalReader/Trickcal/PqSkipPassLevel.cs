using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSkipPassLevel {
    [Key(0)]
    public int EventId { get; set; }
}
