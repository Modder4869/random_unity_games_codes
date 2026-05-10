using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SoloEndClearInfoData {
    [Key(0)]
    public int StageId { get; set; }
    [Key(1)]
    public int[] Heroes { get; set; }
    [Key(2)]
    public short[] HeroLevels { get; set; }
    [Key(3)]
    public short[] HeroGrades { get; set; }
    [Key(4)]
    public int PlayTimeSeconds { get; set; }
    [Key(5)]
    public long HighestScore { get; set; }
    [Key(6)]
    public int StartCoin { get; set; }
    [Key(7)]
    public CacheData<UserProfileCacheData> UserProfile { get; set; }
    [Key(8)]
    public int[] HeroSkins { get; set; }
}
