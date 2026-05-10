using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AuthBanResult {
    [Key(0)]
    public BanType BanType { get; set; }
    [Key(1)]
    public DateTime BanTime { get; set; }
    [Key(2)]
    public int UserId { get; set; }
    [Key(3)]
    public BanReasonType BanReasonType { get; set; }
    [Key(4)]
    public string UserHashTag { get; set; }
}
