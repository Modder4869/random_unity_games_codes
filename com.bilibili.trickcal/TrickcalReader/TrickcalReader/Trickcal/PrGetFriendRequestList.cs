using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetFriendRequestList {
    [Key(0)]
    public List<FriendSimpleData> FriendSimpleDataList { get; set; }
}
