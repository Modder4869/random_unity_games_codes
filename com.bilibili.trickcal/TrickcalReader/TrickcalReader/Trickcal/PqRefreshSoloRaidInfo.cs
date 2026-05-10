using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqRefreshSoloRaidInfo {
    [Key(0)]
    public int SoloRaidId { get; set; }
}
