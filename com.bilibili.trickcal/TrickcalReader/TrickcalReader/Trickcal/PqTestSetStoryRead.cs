using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetStoryRead {
    [Key(0)]
    public int EpisodeUid { get; set; }
    [Key(1)]
    public bool IsRead { get; set; }
}
