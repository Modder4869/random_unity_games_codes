using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetGuildPetRentList {
    [Key(0)]
    public List<GuildPetRentData> RentDataList { get; set; }
}
