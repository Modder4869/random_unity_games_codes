using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrConfirmAllFriendRequest {
    [Key(0)]
    public DateTime ConfirmTime { get; set; }
    [Key(1)]
    public ResultCode[] Results { get; set; }
}
