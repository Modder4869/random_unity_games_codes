using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetUnitSkin {
    [Key(0)]
    public int UnitId { get; set; }
    [Key(1)]
    public int SkinId { get; set; }
}
