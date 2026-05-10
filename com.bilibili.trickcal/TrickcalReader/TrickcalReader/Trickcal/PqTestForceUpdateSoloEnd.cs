using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestForceUpdateSoloEnd {
    [Key(0)]
    public int SoloEndId { get; set; }
}
