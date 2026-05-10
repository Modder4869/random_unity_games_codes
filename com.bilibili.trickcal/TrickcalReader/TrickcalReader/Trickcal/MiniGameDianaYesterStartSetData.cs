using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MiniGameDianaYesterStartSetData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int StageUid { get; set; }
    [Key(2)]
    public int BlockSpawnOrder { get; set; }
    [Key(3)]
    public int[] BlockGroupUid { get; set; }
    [Key(4)]
    public int[] BlockGroupRatio { get; set; }
}
