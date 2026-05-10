using MessagePack;
using System.Collections;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserEventData {
    [Key(0)]
    public DateTime StartTime { get; set; }
    [Key(1)]
    public BitArray Bits { get; set; }
    [Key(2)]
    public int IntValue0 { get; set; }
    [Key(3)]
    public int IntValue1 { get; set; }
}
