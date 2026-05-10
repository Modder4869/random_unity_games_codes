using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct UserSoloEndWorldKey {
    [Key(0)]
    public int SoloEndId { get; set; }
    [Key(1)]
    public int WorldUid { get; set; }
}
