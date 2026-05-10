using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MyHomeHousingFurnitureSlot {
    [Key(1)]
    public int Id { get; set; }
    [Key(2)]
    public int[] CollectionIds { get; set; }
}
