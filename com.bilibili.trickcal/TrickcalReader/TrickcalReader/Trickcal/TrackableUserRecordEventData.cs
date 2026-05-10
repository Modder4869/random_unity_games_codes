using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserRecordEventData {
    [Key(0)]
    public long LongValue0 { get; set; }
    [Key(1)]
    public long LongValue1 { get; set; }
    [Key(2)]
    public DateTime DateTimeValue0 { get; set; }
    [Key(3)]
    public int[] ArrayValue0 { get; set; }
}
