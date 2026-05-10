using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetGuildHeroRentList {
    [Key(0)]
    public List<GuildHeroRentData> RentDataList { get; set; }
}
