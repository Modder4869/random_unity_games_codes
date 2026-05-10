using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SoundResourceData : TableItem<TableData> {
    [Key(0)]
    public string Key { get; set; }
    [Key(1)]
    public string Resource { get; set; }
    [Key(2)]
    public SoundType SoundType { get; set; }
    [Key(3)]
    public PlayType PlayType { get; set; }
    [Key(4)]
    public bool Stoppable { get; set; }
    [Key(5)]
    public float Volume { get; set; }
    [Key(6)]
    public SameEx SameEx { get; set; }
}
