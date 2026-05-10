using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SoloRaidStageRankingCache {
    [Key(0)]
    public CacheData<UserProfileCacheData> UserProfileData { get; set; }
    [Key(1)]
    public CacheData<UserSoloRaidStageClearHeroInfo> UserSoloRaidStageClearHeroInfo { get; set; }
    [Key(2)]
    public int RankingNumber { get; set; }
    [Key(3)]
    public long Score { get; set; }
    [Key(4)]
    public short PlayTimeSeconds { get; set; }
    [Key(5)]
    public long StartTimeTicks { get; set; }
}
