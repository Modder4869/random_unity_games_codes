using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class Theme17Score : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int ModeUid { get; set; }
    [Key(2)]
    public int TimeValue { get; set; }
    [Key(3)]
    public int Score { get; set; }
}
