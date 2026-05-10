using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnSendFriendRequest {
    [Key(0)]
    public int UserId { get; set; }
}
