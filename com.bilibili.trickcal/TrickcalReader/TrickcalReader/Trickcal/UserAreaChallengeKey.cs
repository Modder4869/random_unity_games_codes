using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct UserAreaChallengeKey {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int AreaChallengeUid { get; set; }
}
