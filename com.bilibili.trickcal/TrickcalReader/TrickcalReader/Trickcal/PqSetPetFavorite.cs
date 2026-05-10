using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetPetFavorite {
    [Key(0)]
    public int PetId { get; set; }
    [Key(1)]
    public bool IsFavorite { get; set; }
}
