using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqRefillStamina {
    [Key(0)]
    public short RefillCount { get; set; }
}
