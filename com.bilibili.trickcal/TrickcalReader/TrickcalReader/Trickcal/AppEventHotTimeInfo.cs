using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AppEventHotTimeInfo {
    [Key(0)]
    public DateTime StartTime { get; set; }
    [Key(1)]
    public DateTime EndTime { get; set; }
}
