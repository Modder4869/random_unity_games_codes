using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AlbumStepData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Step { get; set; }
    [Key(2)]
    public OutGameStatType[] OutGameStatType { get; set; }
    [Key(3)]
    public float[] StatParam { get; set; }
    [Key(4)]
    public string[] EffectDesc { get; set; }
    [Key(5)]
    public string HeroAlbum { get; set; }
}
