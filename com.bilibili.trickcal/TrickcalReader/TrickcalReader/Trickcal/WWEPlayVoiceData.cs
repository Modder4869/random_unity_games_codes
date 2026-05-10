using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WWEPlayVoiceData {
    [Key(1)]
    public int UnitUid { get; set; }
    [Key(2)]
    public string Path { get; set; }
    [Key(3)]
    public SoundType SoundType { get; set; }
    [Key(4)]
    public bool Cuttable { get; set; }
}
