using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqUseStoryEpisodeFilm {
    [Key(0)]
    public int EpisodeId { get; set; }
}
