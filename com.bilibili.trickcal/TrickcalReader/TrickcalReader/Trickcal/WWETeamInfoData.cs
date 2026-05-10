using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WWETeamInfoData {
    [Key(0)]
    public CacheData<UserStatData> UserStatData { get; set; }
    [Key(1)]
    public int[] Heroes { get; set; }
    [Key(2)]
    public List<SettingCardData> CardInfos { get; set; }
}
