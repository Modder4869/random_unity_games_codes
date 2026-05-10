using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct UserHeroVoiceKey {
    [Key(0)]
    public int HeroId { get; set; }
    [Key(1)]
    public int SkinId { get; set; }
}
