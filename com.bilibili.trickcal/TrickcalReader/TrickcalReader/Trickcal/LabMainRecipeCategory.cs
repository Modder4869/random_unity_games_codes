using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LabMainRecipeCategory : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int MainTabSort { get; set; }
    [Key(2)]
    public string MainTabName { get; set; }
}
