using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AnniversaryPageOperationData {
    [Key(0)]
    public int DataId { get; set; }
    [Key(1)]
    public bool Enable { get; set; }
    [Key(2)]
    public bool IsAlways { get; set; }
    [Key(3)]
    public DateTime StartTime { get; set; }
    [Key(4)]
    public DateTime EndTime { get; set; }
    [Key(5)]
    public bool Banner { get; set; }
    [Key(6)]
    public int Sort { get; set; }
    [Key(7)]
    public DateTime RealStartTime { get; set; }
    [Key(8)]
    public DateTime RealEndTime { get; set; }
    [Key(9)]
    public DateTime AddLimitTime { get; set; }
}
