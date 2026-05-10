using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqRefillAsideStamina {
    [Key(0)]
    public short RefillCount { get; set; }
}
