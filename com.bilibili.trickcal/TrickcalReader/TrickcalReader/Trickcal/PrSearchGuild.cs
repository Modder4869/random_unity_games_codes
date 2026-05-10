using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrSearchGuild {
    [Key(0)]
    public GuildSearchData SearchData { get; set; }
}
