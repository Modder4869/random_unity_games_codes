using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnSendFriendSocialPoint {
    [Key(0)]
    public int UserId { get; set; }
}
