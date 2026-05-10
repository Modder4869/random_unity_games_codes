using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnGameEventChanged {
    [Key(0)]
    public GameEventData[] GameEvents { get; set; }
}
