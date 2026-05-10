using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveAllFriendSocialPoint {
    [Key(0)]
    public List<int> UserIdList { get; set; }
}
