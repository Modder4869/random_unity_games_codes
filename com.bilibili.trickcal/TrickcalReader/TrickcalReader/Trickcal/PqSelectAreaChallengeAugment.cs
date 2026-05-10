using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSelectAreaChallengeAugment {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int AreaChallengeUid { get; set; }
    [Key(2)]
    public StageDifficultyType Difficulty { get; set; }
    [Key(3)]
    public int AugmentUid { get; set; }
}
