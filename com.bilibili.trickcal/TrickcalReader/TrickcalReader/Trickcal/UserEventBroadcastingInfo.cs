using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UserEventBroadcastingInfo {
    [Key(0)]
    public int BroadcastingUid { get; set; }
    [Key(1)]
    public int BroadcastingValue { get; set; }
    [Key(2)]
    public ContentsType ContentsType { get; set; }
    [Key(3)]
    public int UserId { get; set; }
    [Key(4)]
    public string UserName { get; set; }
}
