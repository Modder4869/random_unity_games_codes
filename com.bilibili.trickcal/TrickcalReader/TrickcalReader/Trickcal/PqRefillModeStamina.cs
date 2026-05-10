using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqRefillModeStamina {
    [Key(0)]
    public short RefillCount { get; set; }
}
