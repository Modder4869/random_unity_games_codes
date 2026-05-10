using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AlbumSubCategoryData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int MainTabUid { get; set; }
    [Key(2)]
    public AlbumType Category { get; set; }
    [Key(3)]
    public int Sort { get; set; }
    [Key(4)]
    public string Name { get; set; }
    [Key(5)]
    public string Icon { get; set; }
}
