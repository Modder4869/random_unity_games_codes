using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserSoloRaidStageData {
    [Key(0)]
    public long Damage { get; set; }
    [Key(1)]
    public int[] Heroes { get; set; }
    [Key(2)]
    public short[] HeroLevels { get; set; }
    [Key(3)]
    public short[] HeroGrades { get; set; }
    [Key(4)]
    public short PlayTimeSeconds { get; set; }
    [Key(5)]
    public DateTime StartTime { get; set; }
    [Key(6)]
    public bool IsHighest { get; set; }
    [Key(7)]
    public int[] HeroSkins { get; set; }
    [Key(8)]
    public long Score { get; set; }
    [Key(9)]
    public long TimeBonus { get; set; }
    [Key(10)]
    public int GroupId { get; set; }
    [Key(11)]
    public short[] HeroAsideGrades { get; set; }
}
