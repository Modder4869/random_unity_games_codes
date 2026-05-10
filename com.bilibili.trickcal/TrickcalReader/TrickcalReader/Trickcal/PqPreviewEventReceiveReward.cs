using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqPreviewEventReceiveReward {
    [Key(0)]
    public int PreviewEventUid { get; set; }
}
