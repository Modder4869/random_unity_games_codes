using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveAnniversaryEventReward {
    [Key(0)]
    public int EventId { get; set; }
}
