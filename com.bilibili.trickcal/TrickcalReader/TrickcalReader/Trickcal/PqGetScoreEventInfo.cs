using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqGetScoreEventInfo {
    [Key(0)]
    public int MixedEventUid { get; set; }
}
