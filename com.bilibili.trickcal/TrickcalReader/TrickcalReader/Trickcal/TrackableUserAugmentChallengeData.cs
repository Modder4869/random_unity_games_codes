using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserAugmentChallengeData {
    [Key(0)]
    public int HighestScore { get; set; }
}
