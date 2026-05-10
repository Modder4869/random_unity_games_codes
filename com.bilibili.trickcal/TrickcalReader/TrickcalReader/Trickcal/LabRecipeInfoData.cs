using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LabRecipeInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public MyHomeContentsType ContentsType { get; set; }
    [Key(2)]
    public int ContentsValue { get; set; }
    [Key(3)]
    public int ProductUid { get; set; }
    [Key(4)]
    public int TimeSeconds { get; set; }
    [Key(5)]
    public int[] NeedItem { get; set; }
    [Key(6)]
    public int[] NeedValue { get; set; }
    [Key(7)]
    public int SubCategoryUid { get; set; }
}
