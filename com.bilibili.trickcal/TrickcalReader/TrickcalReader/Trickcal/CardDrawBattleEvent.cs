using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CardDrawBattleEvent {
    [Key(0)]
    public int EventIndex { get; set; }
    [Key(1)]
    public TimeSpan ElapsedTime { get; set; }
    [Key(2)]
    public int RandomCountStart { get; set; }
    [Key(3)]
    public DrawCardType CardType { get; set; }
    [Key(4)]
    public int CardDrawIndex { get; set; }
    [Key(5)]
    public int CardUid { get; set; }
    [Key(6)]
    public bool IsColorful { get; set; }
}
