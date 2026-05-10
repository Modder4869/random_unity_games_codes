using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct HeroRewardResult {
    [Key(0)]
    public int HeroId { get; set; }
    [Key(1)]
    public int IdCardCount { get; set; }
    [Key(2)]
    public bool IsIdCardToMail { get; set; }
    [Key(3)]
    public bool IsFirstDrop { get; set; }
}
