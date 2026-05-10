using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSendFriendSocialPoint {
    [Key(0)]
    public int UserId { get; set; }
}
