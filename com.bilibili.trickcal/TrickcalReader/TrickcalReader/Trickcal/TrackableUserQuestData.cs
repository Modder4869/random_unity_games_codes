using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserQuestData {
    [Key(0)]
    public short State { get; set; }
    [Key(1)]
    public long Value { get; set; }
    [Key(2)]
    public int Data { get; set; }
}
