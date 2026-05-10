using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestAddOrUpdateHero {
    [Key(0)]
    public int HeroId { get; set; }
    [Key(1)]
    public IUserHeroData UserHeroData { get; set; }
}
