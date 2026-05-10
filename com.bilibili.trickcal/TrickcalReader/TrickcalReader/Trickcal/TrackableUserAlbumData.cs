using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserAlbumData {
    [Key(0)]
    public int Step { get; set; }
    [Key(1)]
    public int Count { get; set; }
    [Key(2)]
    public bool IsReceivedReward { get; set; }
}
