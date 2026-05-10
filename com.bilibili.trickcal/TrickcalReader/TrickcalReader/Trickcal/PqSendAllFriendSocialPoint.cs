using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSendAllFriendSocialPoint {
    [Key(0)]
    public List<int> UserIdList { get; set; }
}
