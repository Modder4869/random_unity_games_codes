using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveDayLimitQuestPointReward {
    [Key(0)]
    public int EventId { get; set; }
    [Key(1)]
    public int Step { get; set; }
}
