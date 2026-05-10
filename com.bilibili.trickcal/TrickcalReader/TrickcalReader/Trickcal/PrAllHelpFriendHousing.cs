using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrAllHelpFriendHousing {
    [Key(0)]
    public List<int> UserIdList { get; set; }
    [Key(1)]
    public List<Goods> HelpFriendGoodsList { get; set; }
    [Key(2)]
    public List<Goods> PetGatherGoodsList { get; set; }
}
