using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AsideLevelUpData : TableItem<TableData> {
    [Key(0)]
    public int Level { get; set; }
    [Key(1)]
    public int NeedExp { get; set; }
    [Key(2)]
    public int SumExp { get; set; }
    [Key(3)]
    public int GetExp { get; set; }
}
