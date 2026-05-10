using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqOpenPet {
    [Key(0)]
    public int PetId { get; set; }
}
