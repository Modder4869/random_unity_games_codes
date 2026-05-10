using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqGetUserProfile {
    [Key(0)]
    public int UserId { get; set; }
}
