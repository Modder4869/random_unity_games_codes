using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnKick {
    [Key(0)]
    public KickReasonType KickReasonType { get; set; }
}
