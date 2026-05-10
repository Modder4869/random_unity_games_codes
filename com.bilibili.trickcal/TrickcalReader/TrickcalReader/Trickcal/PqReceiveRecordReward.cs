using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveRecordReward {
    [Key(0)]
    public int RecordTypeId { get; set; }
}
