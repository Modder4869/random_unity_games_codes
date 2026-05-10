using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrReceiveAllFriendSocialPoint {
    [Key(0)]
    public ResultCode[] Results { get; set; }
}
