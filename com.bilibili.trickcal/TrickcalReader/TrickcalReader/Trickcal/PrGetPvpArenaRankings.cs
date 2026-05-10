using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetPvpArenaRankings {
    [Key(0)]
    public List<PvpArenaUserData> Rankings { get; set; }
}
