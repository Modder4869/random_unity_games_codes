using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserWebLinkData {
    [Key(0)]
    public DateTime StartTime { get; set; }
    [Key(1)]
    public WebLinkState State { get; set; }
}
