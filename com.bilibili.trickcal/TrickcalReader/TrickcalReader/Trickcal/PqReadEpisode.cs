using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReadEpisode {
    [Key(0)]
    public int EpisodeId { get; set; }
    [Key(1)]
    public bool IsSkipped { get; set; }
}
