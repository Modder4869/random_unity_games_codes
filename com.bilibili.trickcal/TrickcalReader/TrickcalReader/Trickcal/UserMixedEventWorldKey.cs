using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct UserMixedEventWorldKey {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int WorldUid { get; set; }
    [Key(2)]
    public StageDifficultyType Difficulty { get; set; }
}
