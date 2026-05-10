using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrContinueAuth {
    [Key(0)]
    public ContinueAuthOkResult Ok { get; set; }
    [Key(1)]
    public AuthMaintenanceResult Maintenance { get; set; }
}
