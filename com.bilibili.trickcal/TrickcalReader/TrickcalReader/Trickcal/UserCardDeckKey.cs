using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct UserCardDeckKey {
    [Key(0)]
    public ModeType Mode { get; set; }
    [Key(1)]
    public short Index { get; set; }
    [Key(2)]
    public short ModeIndex { get; set; }
}
