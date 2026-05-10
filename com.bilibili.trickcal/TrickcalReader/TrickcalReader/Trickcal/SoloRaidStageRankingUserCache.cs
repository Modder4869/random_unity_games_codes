using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SoloRaidStageRankingUserCache {
    [Key(0)]
    public long StartTimeTicks { get; set; }
    [Key(1)]
    public CacheData<UserProfileCacheData> UserProfileData { get; set; }
    [Key(2)]
    public List<SoloRaidStageRankingCache> DataList { get; set; }
}
