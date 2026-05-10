using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSaveMyHomeHousing {
    [Key(0)]
    public MyHomeHousing MyHomeHousing { get; set; }
}
