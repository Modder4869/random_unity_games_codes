using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StatPetData {
    [Key(0)]
    public int PetId { get; set; }
    [Key(1)]
    public int Level { get; set; }
}
