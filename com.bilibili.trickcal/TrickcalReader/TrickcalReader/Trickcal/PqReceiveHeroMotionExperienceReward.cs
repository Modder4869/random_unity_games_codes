using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveHeroMotionExperienceReward {
    [Key(0)]
    public int HeroMotionExperienceEventUid { get; set; }
}
