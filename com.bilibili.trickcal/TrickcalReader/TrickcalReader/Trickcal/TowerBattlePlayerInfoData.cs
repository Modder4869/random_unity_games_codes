using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TowerBattlePlayerInfoData {
    [Key(0)]
    public int UserId { get; set; }
    [Key(1)]
    public string Nickname { get; set; }
    [Key(2)]
    public int ProfileIconId { get; set; }
    [Key(3)]
    public int ProfileBoardId { get; set; }
    [Key(4)]
    public int ProfileNameplateId { get; set; }
    [Key(5)]
    public int Score { get; set; }
    [Key(6)]
    public int WinCount { get; set; }
    [Key(7)]
    public int LoseCount { get; set; }
    [Key(8)]
    public int StreakWinCount { get; set; }
    [Key(9)]
    public int MainProfileHeroId { get; set; }
    [Key(10)]
    public int MainProfileHeroSkinId { get; set; }
    [Key(11)]
    public int ProfileNameStyleId { get; set; }
}
