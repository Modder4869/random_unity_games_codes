using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MiniGameDianaYesterNormalSetData : TableItem<TableData> {
    [Key(0)]
    public int MiniGameUid { get; set; }
    [Key(1)]
    public int StageUid { get; set; }
    [Key(2)]
    public int BlockUid { get; set; }
    [Key(3)]
    public int BlockTotalCount { get; set; }
}
