using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrContinueAutoResearchMyHomeLab {
    [Key(0)]
    public AutoResearchContinueResult Result { get; set; }
}
