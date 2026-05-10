using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEnterSoloRaidInfo {
    [Key(0)]
    public int SoloRaidId { get; set; }
}
