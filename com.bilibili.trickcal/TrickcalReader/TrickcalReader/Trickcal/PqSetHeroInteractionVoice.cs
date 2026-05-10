using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetHeroInteractionVoice {
    [Key(0)]
    public int HeroId { get; set; }
    [Key(1)]
    public int SkinId { get; set; }
    [Key(2)]
    public int[] VoiceIds { get; set; }
}
