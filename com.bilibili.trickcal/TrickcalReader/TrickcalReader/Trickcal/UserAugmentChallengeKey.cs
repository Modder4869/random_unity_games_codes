using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct UserAugmentChallengeKey {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int AugmentChallengeUid { get; set; }
}
