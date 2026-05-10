using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSelectMyHomeLifeSkill {
    [Key(0)]
    public int LifeSkillId { get; set; }
}
