using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqExecuteArcadeSeasonEasterEgg {
    [Key(0)]
    public int ArcadeSeasonUid { get; set; }
    [Key(1)]
    public ArcadeSeasonEasterEggType EasterEggType { get; set; }
}
