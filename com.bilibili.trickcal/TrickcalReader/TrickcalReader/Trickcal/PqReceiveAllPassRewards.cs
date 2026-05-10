using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveAllPassRewards {
    [Key(0)]
    public int EventId { get; set; }
}
