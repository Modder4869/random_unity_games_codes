using MessagePack;

namespace Trickcal.Shared;
using System.Collections;
[MessagePackObject]
public class PqTestSetGatherHero {
    [Key(0)]
    public GatherStatusType GatherStatusType { get; set; }
    [Key(1)]
    public short Level { get; set; }
    [Key(2)]
    public int[] HeroIds { get; set; }
    [Key(3)]
    public BitArray IsBonus { get; set; }
}
