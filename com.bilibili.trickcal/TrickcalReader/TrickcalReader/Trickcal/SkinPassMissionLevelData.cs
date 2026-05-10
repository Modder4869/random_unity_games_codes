using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SkinPassMissionLevelData : TableItem<TableData> {
    [Key(0)]
    public int Level { get; set; }
    [Key(1)]
    public int NeedPassPoint { get; set; }
    [Key(2)]
    public int NeedCash { get; set; }
}
