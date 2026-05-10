using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqLevelUpUserSkill {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int UserSkillId { get; set; }
}
