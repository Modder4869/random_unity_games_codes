using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrainingRoomClearInfoData {
    [Key(0)]
    public int StageId { get; set; }
    [Key(1)]
    public int[] Heroes { get; set; }
    [Key(2)]
    public short[] HeroLevels { get; set; }
    [Key(3)]
    public short[] HeroGrades { get; set; }
    [Key(4)]
    public TimeSpan PlayTime { get; set; }
    [Key(5)]
    public long Score { get; set; }
}
