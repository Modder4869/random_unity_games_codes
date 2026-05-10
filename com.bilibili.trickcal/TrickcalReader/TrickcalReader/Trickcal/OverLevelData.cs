using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class OverLevelData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int HeroUpgrade { get; set; }
    [Key(2)]
    public int OverLevel { get; set; }
}
