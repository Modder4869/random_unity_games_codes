using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WWESoundData {
    [Key(1)]
    public string Path { get; set; }
    [Key(2)]
    public SoundType SoundType { get; set; }
    [Key(3)]
    public int LoopCount { get; set; }
    [Key(4)]
    public float Delay { get; set; }
    [Key(5)]
    public bool OneShot { get; set; }
}
