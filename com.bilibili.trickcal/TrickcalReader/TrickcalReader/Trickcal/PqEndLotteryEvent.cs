using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEndLotteryEvent {
    [Key(0)]
    public int EventUid { get; set; }
}
