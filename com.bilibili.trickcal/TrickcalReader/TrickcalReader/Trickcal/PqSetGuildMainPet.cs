using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetGuildMainPet {
    [Key(0)]
    public int PetId { get; set; }
}
