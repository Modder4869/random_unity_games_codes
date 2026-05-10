using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSearchFriends {
    [Key(0)]
    public string SearchUserName { get; set; }
    [Key(1)]
    public string SearchFriendCode { get; set; }
}
