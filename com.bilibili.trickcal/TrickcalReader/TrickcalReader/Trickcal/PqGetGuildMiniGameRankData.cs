using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqGetGuildMiniGameRankData {
    [Key(0)]
    public int MiniGameUid { get; set; }
}
