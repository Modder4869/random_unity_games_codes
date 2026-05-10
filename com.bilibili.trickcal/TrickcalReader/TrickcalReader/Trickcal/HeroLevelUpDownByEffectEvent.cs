using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HeroLevelUpDownByEffectEvent {
    [Key(0)]
    public int EventIndex { get; set; }
    [Key(1)]
    public TimeSpan ElapsedTime { get; set; }
    [Key(2)]
    public int RandomCountStart { get; set; }
    [Key(3)]
    public bool IsEffectFromCard { get; set; }
    [Key(4)]
    public int HeroUid { get; set; }
    [Key(5)]
    public int LevelBefore { get; set; }
    [Key(6)]
    public int LevelAfter { get; set; }
    [Key(7)]
    public int CardOrSlotUid { get; set; }
}
