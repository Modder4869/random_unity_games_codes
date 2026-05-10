using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqGetGuildRecommendList {
    [Key(0)]
    public GuildFilter Filter { get; set; }
}
