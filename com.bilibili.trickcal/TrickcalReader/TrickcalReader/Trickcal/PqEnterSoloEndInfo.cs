using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEnterSoloEndInfo {
    [Key(0)]
    public int SoloEndId { get; set; }
}
