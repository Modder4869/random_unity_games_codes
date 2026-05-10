using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SoloRaidRankingData {
    [Key(0)]
    public CacheData<UserProfileCacheData> UserProfileData { get; set; }
    [Key(1)]
    public long Score { get; set; }
    [Key(2)]
    public int RankingNumber { get; set; }
    [Key(3)]
    public int UserId { get; set; }
}
