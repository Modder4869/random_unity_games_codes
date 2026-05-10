using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqDeleteFriend {
    [Key(0)]
    public int UserId { get; set; }
}
