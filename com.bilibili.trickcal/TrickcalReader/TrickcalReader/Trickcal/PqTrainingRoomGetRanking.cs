using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTrainingRoomGetRanking {
    [Key(0)]
    public int TrainingRoomId { get; set; }
    [Key(1)]
    public bool IsFullPowerSetting { get; set; }
}
