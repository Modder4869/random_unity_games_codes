using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WWESpineEffectData {
    [Key(15)]
    public string Animation { get; set; }
    [Key(16)]
    public float AniTimeScale { get; set; }
    [Key(17)]
    public bool IsLoop { get; set; }
}
