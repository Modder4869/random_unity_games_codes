using MessagePack;
using System.Collections;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserPuppetStoryData {
    [Key(0)]
    public BitArray IsEpisodeWatched { get; set; }
}
