using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqGuildPetInteraction {
    [Key(0)]
    public int PetId { get; set; }
}
