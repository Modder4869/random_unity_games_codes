using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveAllAffinityPassReward {
    [Key(0)]
    public int[] HeroIds { get; set; }
}
