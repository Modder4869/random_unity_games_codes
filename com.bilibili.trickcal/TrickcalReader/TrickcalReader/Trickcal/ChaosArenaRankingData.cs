using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ChaosArenaRankingData {
    [Key(0)]
    public int UserId { get; set; }
    [Key(1)]
    public CacheData<UserProfileCacheData> UserProfileData { get; set; }
    [Key(2)]
    public CacheData<UserStatData> UserStatData { get; set; }
    [Key(3)]
    public int Ranking { get; set; }
    [Key(4)]
    public int Score { get; set; }
    [Key(5)]
    public int[] DefenseHeroes { get; set; }
}
