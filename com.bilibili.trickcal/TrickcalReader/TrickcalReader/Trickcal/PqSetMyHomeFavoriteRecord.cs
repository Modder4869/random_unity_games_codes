using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetMyHomeFavoriteRecord {
    [Key(0)]
    public int CollectionRecordId { get; set; }
    [Key(1)]
    public bool IsFavorite { get; set; }
}
