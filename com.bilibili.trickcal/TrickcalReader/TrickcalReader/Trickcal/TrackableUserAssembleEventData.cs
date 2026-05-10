using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserAssembleEventData {
    [Key(0)]
    public int[] ReceivedAssembleUids { get; set; }
    [Key(1)]
    public int[] ReceivedAssembleGroupUids { get; set; }
}
