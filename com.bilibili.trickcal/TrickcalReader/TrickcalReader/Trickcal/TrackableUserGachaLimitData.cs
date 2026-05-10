using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserGachaLimitData {
    [Key(0)]
    public int GachaCount { get; set; }
}
