using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSendFriendRequest {
    [Key(0)]
    public int UserId { get; set; }
}
