using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StagePowerData {
    [Key(0)]
    public List<int> HeroIds { get; set; }
    [Key(1)]
    public List<int> HeroPowers { get; set; }
}
