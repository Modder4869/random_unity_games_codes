using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class RenewaMiniGameServerResultData {
    [Key(0)]
    public List<int> ReceivedEasterEggs { get; set; }
    [Key(1)]
    public int Score { get; set; }
    [Key(2)]
    public List<int> ReceivedEasterEggTimeIndexes { get; set; }
}
