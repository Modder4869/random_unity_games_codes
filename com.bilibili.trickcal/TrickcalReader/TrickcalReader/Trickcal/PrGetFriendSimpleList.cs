using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetFriendSimpleList {
    [Key(0)]
    public List<FriendSimpleData> FriendSimpleDataList { get; set; }
}
