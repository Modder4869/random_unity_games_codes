using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SoloRaidStageClearInfoData {
    [Key(0)]
    public int StageId { get; set; }
    [Key(1)]
    public long Score { get; set; }
    [Key(2)]
    public int[] Heroes { get; set; }
    [Key(3)]
    public short[] HeroLevels { get; set; }
    [Key(4)]
    public short[] HeroGrades { get; set; }
    [Key(5)]
    public int[] HeroSkins { get; set; }
    [Key(6)]
    public int Order { get; set; }
    [Key(7)]
    public short PlayTimeSeconds { get; set; }
    [Key(8)]
    public long TimeBonus { get; set; }
    [Key(9)]
    public bool IsClear { get; set; }
}
