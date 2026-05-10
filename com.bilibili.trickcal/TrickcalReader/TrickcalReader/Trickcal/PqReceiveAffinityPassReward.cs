using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveAffinityPassReward {
    [Key(0)]
    public int HeroId { get; set; }
    [Key(1)]
    public int AffinityLevel { get; set; }
}
