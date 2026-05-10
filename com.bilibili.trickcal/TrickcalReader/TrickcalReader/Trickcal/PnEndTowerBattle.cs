using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnEndTowerBattle {
    [Key(0)]
    public TowerBattleResultType Result { get; set; }
    [Key(1)]
    public int ChangeScore { get; set; }
    [Key(2)]
    public int OpponentUserId { get; set; }
    [Key(3)]
    public int StreakWinScore { get; set; }
}
