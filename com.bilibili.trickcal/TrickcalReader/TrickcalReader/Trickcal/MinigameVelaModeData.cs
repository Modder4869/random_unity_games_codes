using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MinigameVelaModeData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string ModeName { get; set; }
    [Key(2)]
    public int Stage { get; set; }
    [Key(3)]
    public int SpeedGroup { get; set; }
    [Key(4)]
    public MiniGameStageUnlockType UnlockType { get; set; }
    [Key(5)]
    public int[] UnlockValues { get; set; }
}
