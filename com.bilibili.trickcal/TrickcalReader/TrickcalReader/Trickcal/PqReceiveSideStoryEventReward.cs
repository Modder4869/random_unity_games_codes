using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveSideStoryEventReward {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int SideStoryUid { get; set; }
}
