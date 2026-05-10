using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PvpArenaUserData {
    [Key(0)]
    public CacheData<UserProfileCacheData> UserProfileData { get; set; }
    [Key(1)]
    public CacheData<UserStatData> UserStatData { get; set; }
    [Key(2)]
    public int Ranking { get; set; }
    [Key(3)]
    public int HeroHiddenBits { get; set; }
    [Key(4)]
    public int[] HeroIds { get; set; }
    [Key(5)]
    public int UserId { get; set; }
    [Key(6)]
    public int[] HeroIndexes { get; set; }
}
