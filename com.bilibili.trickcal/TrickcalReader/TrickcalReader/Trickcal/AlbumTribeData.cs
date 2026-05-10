using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AlbumTribeData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public TribeType TribeType { get; set; }
    [Key(2)]
    public int Step { get; set; }
    [Key(3)]
    public string Title { get; set; }
    [Key(4)]
    public string Desc { get; set; }
    [Key(5)]
    public EpisodeUnlockType UnlockType { get; set; }
    [Key(6)]
    public int UnlockValue { get; set; }
}
