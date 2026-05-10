using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnConfirmFriendRequest {
    [Key(0)]
    public int UserId { get; set; }
    [Key(1)]
    public bool Accept { get; set; }
}
