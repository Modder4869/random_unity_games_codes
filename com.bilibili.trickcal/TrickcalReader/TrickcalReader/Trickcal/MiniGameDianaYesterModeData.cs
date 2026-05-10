using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MiniGameDianaYesterModeData : TableItem<TableData> {
    [Key(1)]
    public string ModeName { get; set; }
    [Key(2)]
    public int StageUid { get; set; }
    [Key(3)]
    public MiniGameStageUnlockType UnlockType { get; set; }
    [Key(4)]
    public int[] UnlockValues { get; set; }
    [Key(5)]
    public float DropSpeedUp { get; set; }
    [Key(6)]
    public int DropSpeedTimeValue { get; set; }
    [Key(7)]
    public float DropSpeedMax { get; set; }
}
