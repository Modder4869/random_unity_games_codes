using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct UserSoloRaidStageKey {
    [Key(0)]
    public int SoloRaidId { get; set; }
    [Key(1)]
    public int StageId { get; set; }
    [Key(2)]
    public short DataIndex { get; set; }
    [Key(3)]
    public short Index { get; set; }
}
