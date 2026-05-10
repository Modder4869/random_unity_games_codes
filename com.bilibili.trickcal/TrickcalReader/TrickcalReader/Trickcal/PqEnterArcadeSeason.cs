using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEnterArcadeSeason {
    [Key(0)]
    public int ArcadeSeasonUid { get; set; }
}
