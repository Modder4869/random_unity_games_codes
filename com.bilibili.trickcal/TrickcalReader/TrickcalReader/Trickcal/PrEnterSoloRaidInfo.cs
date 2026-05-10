using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrEnterSoloRaidInfo {
    [Key(0)]
    public SoloRaidState State { get; set; }
}
