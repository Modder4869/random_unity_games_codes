using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserSkinData {
    [Key(0)]
    public int SkinBGId { get; set; }
    [Key(1)]
    public int[] SkinDetailIds { get; set; }
}
