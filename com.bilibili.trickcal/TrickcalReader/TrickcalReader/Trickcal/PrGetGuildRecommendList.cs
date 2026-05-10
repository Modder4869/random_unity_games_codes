using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetGuildRecommendList {
    [Key(0)]
    public List<GuildSearchData> SearchDataList { get; set; }
}
