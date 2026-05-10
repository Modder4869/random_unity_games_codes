using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MyHomeCollectionData : TableItem<TableData> {
    [Key(0)]
    public TableBaseItemData ItemData { get; set; }
    [Key(1)]
    public FurnitureCollectionType CollectionType { get; set; }
    [Key(2)]
    public bool Default { get; set; }
    [Key(3)]
    public int Size { get; set; }
    [Key(4)]
    public string Resource { get; set; }
    [Key(5)]
    public int Fame { get; set; }
    [Key(6)]
    public string Sound { get; set; }
    [Key(7)]
    public int Time { get; set; }
    [Key(8)]
    public string Composer { get; set; }
    [Key(9)]
    public string Spine { get; set; }
}
