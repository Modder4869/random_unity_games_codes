using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserTrickcalRankMatchRecordData {
    [Key(0)]
    public int SeasonId { get; set; }
    [Key(1)]
    public int MatchUserId { get; set; }
    [Key(2)]
    public TierGrade MatchUserTier { get; set; }
    [Key(3)]
    public int MatchUserLevel { get; set; }
    [Key(4)]
    public int[] MatchUserDefenseHeroes { get; set; }
    [Key(5)]
    public short[] MatchUserDefenseHeroLevels { get; set; }
    [Key(6)]
    public short[] MatchUserDefenseHeroGrades { get; set; }
    [Key(7)]
    public bool[] IsWins { get; set; }
    [Key(8)]
    public string Nickname { get; set; }
    [Key(9)]
    public int[] HighestHeroes { get; set; }
}
