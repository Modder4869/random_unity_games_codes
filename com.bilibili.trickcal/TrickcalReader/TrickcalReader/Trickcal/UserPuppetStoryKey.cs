using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct UserPuppetStoryKey {
    [Key(0)]
    public PuppetEpisodeLinkType EpisodeLinkType { get; set; }
    [Key(1)]
    public int EpisodeLinkValue { get; set; }
}
