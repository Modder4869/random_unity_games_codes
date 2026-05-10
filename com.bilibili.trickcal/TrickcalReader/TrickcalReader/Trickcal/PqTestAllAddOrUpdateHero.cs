using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestAllAddOrUpdateHero {
    [Key(0)]
    public List<int> HeroIds { get; set; }
    [Key(1)]
    public List<TrackableUserHeroData> UserHeroDataList { get; set; }
}
