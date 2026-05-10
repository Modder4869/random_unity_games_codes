using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MiniGameRankUserData {
    [Key(0)]
    public string Nickname { get; set; }
    [Key(1)]
    public int ProfileIcon { get; set; }
    [Key(2)]
    public int ProfileBorder { get; set; }
    [Key(3)]
    public int Score { get; set; }
    [Key(4)]
    public DateTime LastPlayTime { get; set; }
    [Key(5)]
    public int Ranking { get; set; }
    [Key(6)]
    public int UserId { get; set; }
    [Key(7)]
    public int ProfileNameplate { get; set; }
    [Key(8)]
    public int ProfileNameStyle { get; set; }
}
