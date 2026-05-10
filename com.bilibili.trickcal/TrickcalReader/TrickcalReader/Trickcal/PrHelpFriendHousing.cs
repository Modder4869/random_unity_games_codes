using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrHelpFriendHousing {
    [Key(0)]
    public bool IsTrigger { get; set; }
    [Key(1)]
    public List<int> UserIdList { get; set; }
}
