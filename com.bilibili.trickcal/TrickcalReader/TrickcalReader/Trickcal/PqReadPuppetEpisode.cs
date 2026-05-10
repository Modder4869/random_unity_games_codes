using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReadPuppetEpisode {
    [Key(0)]
    public int PuppetEpisodeId { get; set; }
    [Key(1)]
    public bool IsSkipped { get; set; }
}
