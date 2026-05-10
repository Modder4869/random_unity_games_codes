using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrEndGachaponEvent {
    [Key(1)]
    public bool IsEnd { get; set; }
}
