using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqGetFriendRequestList {
    [Key(0)]
    public int Page { get; set; }
    [Key(1)]
    public int Length { get; set; }
}
