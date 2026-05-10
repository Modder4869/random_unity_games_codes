using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrReceiveGuildDefaultPet {
    [Key(0)]
    public bool IsReceived { get; set; }
}
