using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrDrawGachaponEvent {
    [Key(0)]
    public DrawGachaponResult[] DrawResult { get; set; }
}
