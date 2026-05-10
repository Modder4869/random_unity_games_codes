using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserGatherHeroData {
    [Key(0)]
    public short Level { get; set; }
}
