using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqExchangePetFreeMileage {
    [Key(0)]
    public int PetId { get; set; }
}
