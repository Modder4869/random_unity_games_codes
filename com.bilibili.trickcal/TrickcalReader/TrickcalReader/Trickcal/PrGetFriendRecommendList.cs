using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetFriendRecommendList {
    [Key(0)]
    public List<FriendSimpleData> FriendSimpleDataList { get; set; }
}
