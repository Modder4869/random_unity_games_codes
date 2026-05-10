using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveFriendSocialPoint {
    [Key(0)]
    public int UserId { get; set; }
}
