using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqResetSoloEndNormalWorld {
    [Key(0)]
    public int SoloEndId { get; set; }
    [Key(1)]
    public int WorldId { get; set; }
}
