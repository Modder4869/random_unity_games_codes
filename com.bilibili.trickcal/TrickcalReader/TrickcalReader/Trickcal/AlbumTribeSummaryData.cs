using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AlbumTribeSummaryData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public AlbumType Type { get; set; }
    [Key(2)]
    public int Sort { get; set; }
    [Key(3)]
    public TribeType Tribe { get; set; }
    [Key(4)]
    public string Title { get; set; }
    [Key(5)]
    public string[] Desc { get; set; }
    [Key(6)]
    public string Background { get; set; }
    [Key(7)]
    public string[] Image { get; set; }
}
