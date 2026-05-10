using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AuthMaintenanceResult {
    [Key(0)]
    public DateTime StartTime { get; set; }
    [Key(1)]
    public DateTime EndTime { get; set; }
    [Key(2)]
    public string Message { get; set; }
    [Key(3)]
    public StringUsageType MessageType { get; set; }
    [Key(4)]
    public string[] MessageValues { get; set; }
}
