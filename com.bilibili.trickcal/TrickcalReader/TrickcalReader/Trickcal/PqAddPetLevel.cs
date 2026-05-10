using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqAddPetLevel {
    [Key(0)]
    public int PetId { get; set; }
}
