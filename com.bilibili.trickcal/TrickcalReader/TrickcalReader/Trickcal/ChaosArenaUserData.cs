using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ChaosArenaUserData {
    [Key(0)]
    public CacheData<UserProfileCacheData> UserProfileData { get; set; }
    [Key(1)]
    public CacheData<UserStatData> UserStatData { get; set; }
    [Key(2)]
    public int[] DefenseHeroes { get; set; }
    [Key(3)]
    public int Score { get; set; }
    [Key(4)]
    public List<SettingCardData> DefenseCardInfos { get; set; }
}
