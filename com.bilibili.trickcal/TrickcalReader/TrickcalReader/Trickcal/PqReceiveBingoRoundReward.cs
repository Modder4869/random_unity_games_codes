using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveBingoRoundReward {
    [Key(0)]
    public int BingoEventUid { get; set; }
}
