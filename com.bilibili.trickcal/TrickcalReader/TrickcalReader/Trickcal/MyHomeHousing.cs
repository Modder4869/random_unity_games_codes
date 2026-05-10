using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MyHomeHousing {
    [Key(0)]
    public int LayoutId { get; set; }
    [Key(1)]
    public List<MyHomeHousingFloor> HomeHousingFloors { get; set; }
}
