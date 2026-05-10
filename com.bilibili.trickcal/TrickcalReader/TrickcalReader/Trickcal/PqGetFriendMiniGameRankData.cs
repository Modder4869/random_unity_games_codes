using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqGetFriendMiniGameRankData {
    [Key(0)]
    public int MiniGameUid { get; set; }
}
