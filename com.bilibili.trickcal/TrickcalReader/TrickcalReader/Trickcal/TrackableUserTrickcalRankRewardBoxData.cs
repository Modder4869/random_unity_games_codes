using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserTrickcalRankRewardBoxData {
    [Key(0)]
    public int BoxId { get; set; }
    [Key(1)]
    public DateTime OpenBoxTime { get; set; }
}
