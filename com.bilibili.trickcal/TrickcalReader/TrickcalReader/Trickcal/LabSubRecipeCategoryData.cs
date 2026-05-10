using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LabSubRecipeCategoryData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int SubTabSort { get; set; }
    [Key(3)]
    public bool MaxOk { get; set; }
    [Key(4)]
    public string SubTabName { get; set; }
    [Key(5)]
    public int MainTabUid { get; set; }
}
