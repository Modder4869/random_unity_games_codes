using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetUnitSkinBG {
    [Key(0)]
    public int SkinId { get; set; }
    [Key(1)]
    public int SkinBGId { get; set; }
}
