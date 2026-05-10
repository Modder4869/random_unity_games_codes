using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetHeroSkinDetail {
    [Key(0)]
    public int SkinId { get; set; }
    [Key(1)]
    public int[] SkinDetailIds { get; set; }
}
