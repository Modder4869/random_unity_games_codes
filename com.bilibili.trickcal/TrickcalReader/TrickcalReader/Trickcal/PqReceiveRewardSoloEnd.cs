using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveRewardSoloEnd {
    [Key(0)]
    public int SoloEndId { get; set; }
}
