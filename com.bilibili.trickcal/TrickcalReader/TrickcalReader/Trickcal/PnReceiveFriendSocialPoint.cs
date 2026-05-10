using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnReceiveFriendSocialPoint {
    [Key(0)]
    public int UserId { get; set; }
}
