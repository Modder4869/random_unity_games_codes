using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct EventBonusHeroGroupKey {
    [Key(0)]
    public int GroupUid { get; set; }
    [Key(1)]
    public int WorldUid { get; set; }
}
