using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrConfirmFriendRequest {
    [Key(0)]
    public DateTime ConfirmTime { get; set; }
    [Key(1)]
    public ResultCode Result { get; set; }
}
