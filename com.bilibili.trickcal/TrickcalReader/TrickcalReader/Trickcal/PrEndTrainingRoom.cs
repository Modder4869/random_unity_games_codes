using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrEndTrainingRoom {
    [Key(0)]
    public long Score { get; set; }
    [Key(1)]
    public long TimeBonus { get; set; }
    [Key(2)]
    public int PlayTimeInSeconds { get; set; }
    [Key(3)]
    public bool IsBestScore { get; set; }
}
