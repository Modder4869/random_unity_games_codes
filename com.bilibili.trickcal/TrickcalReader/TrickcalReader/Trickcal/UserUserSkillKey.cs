using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct UserUserSkillKey {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int UserSkillUid { get; set; }
}
