using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqConfirmAllFriendRequest {
    [Key(0)]
    public List<int> UserIdList { get; set; }
    [Key(1)]
    public bool Accept { get; set; }
}
