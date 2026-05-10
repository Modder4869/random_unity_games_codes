using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSettingHero {
    [Key(0)]
    public int HeroId { get; set; }
    [Key(1)]
    public bool? IsHideLobby { get; set; }
    [Key(2)]
    public bool? IsFoodLike { get; set; }
    [Key(3)]
    public bool? IsLove { get; set; }
}
