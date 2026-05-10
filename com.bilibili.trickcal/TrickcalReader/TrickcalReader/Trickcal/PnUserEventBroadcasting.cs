using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnUserEventBroadcasting {
    [Key(0)]
    public List<UserEventBroadcastingInfo> BroadcastingInfoList { get; set; }
}
