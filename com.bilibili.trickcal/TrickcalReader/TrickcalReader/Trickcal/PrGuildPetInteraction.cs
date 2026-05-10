using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGuildPetInteraction {
    [Key(0)]
    public bool IsRewardReceived { get; set; }
}
