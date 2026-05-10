using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CardRerollBattleEvent {
    [Key(0)]
    public int EventIndex { get; set; }
    [Key(1)]
    public TimeSpan ElapsedTime { get; set; }
    [Key(2)]
    public int RandomCountStart { get; set; }
}
