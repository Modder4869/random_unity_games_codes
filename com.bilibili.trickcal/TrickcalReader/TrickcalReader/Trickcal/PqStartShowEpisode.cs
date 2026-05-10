using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqStartShowEpisode {
    [Key(0)]
    public int EpisodeId { get; set; }
}
