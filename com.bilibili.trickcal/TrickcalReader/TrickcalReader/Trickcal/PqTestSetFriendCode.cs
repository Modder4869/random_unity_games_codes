using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetFriendCode {
    [Key(0)]
    public string FriendCode { get; set; }
}
