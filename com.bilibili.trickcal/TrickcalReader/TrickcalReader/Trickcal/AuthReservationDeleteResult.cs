using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AuthReservationDeleteResult {
    [Key(0)]
    public DateTime ReservationDeleteTime { get; set; }
}
