using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSynthesisSummonsCard {
    [Key(0)]
    public int SummonsCardUid { get; set; }
    [Key(1)]
    public int Count { get; set; }
}
