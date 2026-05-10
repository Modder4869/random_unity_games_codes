using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SoloEndMonsterLevelData : TableItem<TableData> {
    [Key(0)]
    public int GroupUid { get; set; }
    [Key(1)]
    public int StageOrder { get; set; }
    [Key(2)]
    public int TargetUid { get; set; }
    [Key(3)]
    public int[] Param { get; set; }
}
