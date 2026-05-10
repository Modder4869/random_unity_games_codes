using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CookingTycoonRankingData {
    [Key(0)]
    public int UserId { get; set; }
    [Key(1)]
    public CacheData<UserProfileCacheData> UserProfileData { get; set; }
    [Key(2)]
    public int Ranking { get; set; }
    [Key(3)]
    public int Score { get; set; }
    [Key(4)]
    public DateTime StartTime { get; set; }
}
