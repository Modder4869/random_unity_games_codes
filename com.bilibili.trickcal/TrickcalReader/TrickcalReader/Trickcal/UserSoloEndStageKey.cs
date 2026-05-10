using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct UserSoloEndStageKey {
    [Key(0)]
    public int SoloEndId { get; set; }
    [Key(1)]
    public int StageUid { get; set; }
}
