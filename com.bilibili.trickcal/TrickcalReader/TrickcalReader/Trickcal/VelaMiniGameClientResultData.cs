using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class VelaMiniGameClientResultData {
    [Key(0)]
    public int Stage { get; set; }
    [Key(1)]
    public int Score { get; set; }
    [Key(2)]
    public int MaxCombo { get; set; }
    [Key(3)]
    public TimeSpan Time { get; set; }
    [Key(4)]
    public List<VelaMiniGameClientResultData.UnitData> UnitDataList { get; set; }

    [MessagePackObject]
    public class UnitData {
        [Key(0)]
        public int UnitId { get; set; }
        [Key(1)]
        public VelaMinigameUnitType Type { get; set; }
        [Key(2)]
        public VelaMiniGameUnitActionType ActionType { get; set; }
        [Key(3)]
        public int TimingMs { get; set; }
        [Key(4)]
        public int SpeedLevel { get; set; }
        [Key(5)]
        public int FeverLevel { get; set; }
    }
}
