using MessagePack;
using System.Collections;
namespace Trickcal.Shared;

[MessagePackObject]
public class StatGatherHeroData {
    [Key(0)]
    public GatherStatusType Type { get; set; }
    [Key(1)]
    public int[] HeroIds { get; set; }
    [Key(2)]
    public BitArray IsBonus { get; set; }
    [Key(3)]
    public short Level { get; set; }
}
