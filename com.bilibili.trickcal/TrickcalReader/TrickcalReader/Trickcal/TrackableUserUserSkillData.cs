using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserUserSkillData {
    [Key(0)]
    public int Level { get; set; }
}
