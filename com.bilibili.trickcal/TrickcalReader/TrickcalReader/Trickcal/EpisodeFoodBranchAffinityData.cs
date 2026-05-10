using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class EpisodeFoodBranchAffinityData {
    [Key(0)]
    public int EpisodeUid { get; set; }
    [Key(1)]
    public DialogueAffinityType[] Affinities { get; set; }
}
