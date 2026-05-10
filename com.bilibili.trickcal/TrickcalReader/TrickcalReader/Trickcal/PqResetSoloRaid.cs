using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqResetSoloRaid {
    [Key(0)]
    public int SoloRaidId { get; set; }
}
