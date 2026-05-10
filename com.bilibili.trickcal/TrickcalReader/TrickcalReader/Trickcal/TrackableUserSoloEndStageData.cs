using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserSoloEndStageData {
    [Key(0)]
    public int[] UsedHeroes { get; set; }
    [Key(1)]
    public short[] HeroLevels { get; set; }
    [Key(2)]
    public short[] HeroGrades { get; set; }
    [Key(3)]
    public short PlayTimeSeconds { get; set; }
    [Key(4)]
    public DateTime StartTime { get; set; }
    [Key(5)]
    public long HighestScore { get; set; }
    [Key(6)]
    public short StartCoin { get; set; }
    [Key(7)]
    public int WorldId { get; set; }
    [Key(8)]
    public int DeckPower { get; set; }
    [Key(9)]
    public int[] HeroSkins { get; set; }
    [Key(10)]
    public int GroupId { get; set; }
    [Key(11)]
    public short[] HeroAsideGrades { get; set; }
}
