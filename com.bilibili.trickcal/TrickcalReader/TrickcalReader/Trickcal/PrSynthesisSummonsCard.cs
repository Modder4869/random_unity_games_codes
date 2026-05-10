using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrSynthesisSummonsCard {
    [Key(0)]
    public SynthesisSummonsCardResult[] SynthesisSummonsCardResult { get; set; }
}
