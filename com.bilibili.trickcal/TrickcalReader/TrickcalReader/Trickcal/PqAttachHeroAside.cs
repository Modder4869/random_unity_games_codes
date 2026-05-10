using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqAttachHeroAside {
    [Key(0)]
    public int HeroId { get; set; }
}
