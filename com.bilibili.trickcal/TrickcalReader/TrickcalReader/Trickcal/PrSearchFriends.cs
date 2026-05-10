using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrSearchFriends {
    [Key(0)]
    public List<FriendSimpleData> FriendSimpleDataList { get; set; }
}
