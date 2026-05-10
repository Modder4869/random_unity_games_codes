using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetMyHomePets {
    [Key(0)]
    public int[] PetIds { get; set; }
}
