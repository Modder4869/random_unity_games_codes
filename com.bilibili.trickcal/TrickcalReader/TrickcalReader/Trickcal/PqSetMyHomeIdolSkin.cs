using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetMyHomeIdolSkin {
    [Key(0)]
    public int IdolSkinId { get; set; }
}
