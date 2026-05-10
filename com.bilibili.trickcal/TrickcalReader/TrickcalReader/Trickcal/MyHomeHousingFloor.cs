using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MyHomeHousingFloor {
    [Key(1)]
    public int Floor { get; set; }
    [Key(2)]
    public Dictionary<FurnitureCategoryType, MyHomeHousingFurnitureSlot[]> FurnitureSlotsMap { get; set; }
}
