using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEndMyHomeFoodEat {
    [Key(0)]
    public int HeroId { get; set; }
    [Key(1)]
    public int EpisodeId { get; set; }
    [Key(2)]
    public short BranchIndex { get; set; }
}
