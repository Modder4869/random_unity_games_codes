using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrAuth {
    [Key(0)]
    public AuthOkResult Ok { get; set; }
    [Key(1)]
    public AuthMaintenanceResult Maintenance { get; set; }
    [Key(2)]
    public AuthReservationDeleteResult ReservationDelete { get; set; }
    [Key(3)]
    public AuthBanResult Ban { get; set; }
    [Key(4)]
    public int LastStage { get; set; }
}
