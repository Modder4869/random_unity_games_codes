using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrSendAllFriendSocialPoint {
    [Key(0)]
    public DateTime SendTime { get; set; }
    [Key(1)]
    public ResultCode[] Results { get; set; }
}
