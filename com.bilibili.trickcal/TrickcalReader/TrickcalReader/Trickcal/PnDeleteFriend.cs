using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnDeleteFriend {
    [Key(0)]
    public int UserId { get; set; }
}
