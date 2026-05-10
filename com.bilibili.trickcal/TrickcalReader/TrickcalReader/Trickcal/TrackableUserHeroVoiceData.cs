using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserHeroVoiceData {
    [Key(0)]
    public int[] InteractionVoiceIds { get; set; }
}
