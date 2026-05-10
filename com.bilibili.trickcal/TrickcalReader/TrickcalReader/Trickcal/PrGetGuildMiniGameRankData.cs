using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetGuildMiniGameRankData {
    [Key(0)]
    public List<MiniGameRankUserData> MiniGameUserRankDatas { get; set; }
}
