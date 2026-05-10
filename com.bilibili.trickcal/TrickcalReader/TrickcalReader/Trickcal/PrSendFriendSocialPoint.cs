using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrSendFriendSocialPoint {
    [Key(0)]
    public DateTime SendTime { get; set; }
}
