using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetFriendMiniGameRankData {
    [Key(0)]
    public List<MiniGameRankUserData> MiniGameUserRankDatas { get; set; }
}
