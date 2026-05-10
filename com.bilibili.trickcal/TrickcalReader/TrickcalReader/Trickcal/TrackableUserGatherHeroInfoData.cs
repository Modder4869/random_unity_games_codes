using MessagePack;
using System.Collections;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserGatherHeroInfoData {
    [Key(0)]
    public int[] HeroIds { get; set; }
    [Key(1)]
    public int HeroPositionSeed { get; set; }
    [Key(2)]
    public BitArray IsBonus { get; set; }
}
