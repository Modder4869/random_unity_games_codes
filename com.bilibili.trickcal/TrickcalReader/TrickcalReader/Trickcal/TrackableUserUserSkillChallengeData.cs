using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserUserSkillChallengeData {
    [Key(0)]
    public int HighestScore { get; set; }
}
