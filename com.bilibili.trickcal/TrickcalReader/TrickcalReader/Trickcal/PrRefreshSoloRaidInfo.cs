using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrRefreshSoloRaidInfo {
    [Key(0)]
    public SoloRaidState State { get; set; }
}
