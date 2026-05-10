using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqStartShowPuppetEpisode {
    [Key(0)]
    public int PuppetEpisodeId { get; set; }
}
