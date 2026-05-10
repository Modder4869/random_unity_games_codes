using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HeroEpisodeFoodBranchAffinityData {
    [Key(0)]
    public int HeroId { get; set; }
    [Key(1)]
    public EpisodeFoodBranchAffinityData[] Episodes { get; set; }
}
