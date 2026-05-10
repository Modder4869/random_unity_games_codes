using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserTrainingRoomData {
    [Key(0)]
    public bool IsFullPowerSetting { get; set; }
    [Key(1)]
    public int StageId { get; set; }
    [Key(2)]
    public long Score { get; set; }
    [Key(3)]
    public int PlayTimeInSeconds { get; set; }
    [Key(4)]
    public int[] HeroIds { get; set; }
    [Key(5)]
    public short[] HeroLevels { get; set; }
    [Key(6)]
    public short[] HeroGrades { get; set; }
    [Key(7)]
    public DateTime PlayDateTime { get; set; }
    [Key(8)]
    public long TimeBonus { get; set; }
    [Key(9)]
    public ModeType ModeType { get; set; }
    [Key(10)]
    public int RelatedEventId { get; set; }
    [Key(11)]
    public int[] HeroSkins { get; set; }
}
