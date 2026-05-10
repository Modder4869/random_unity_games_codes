using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqGuildBeginnerSupport {
    [Key(0)]
    public int TargetUserId { get; set; }
}
