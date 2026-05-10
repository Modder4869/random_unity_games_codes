using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableSideStoryData {
    [Key(0)]
    public int[] WatchedStories { get; set; }
}
