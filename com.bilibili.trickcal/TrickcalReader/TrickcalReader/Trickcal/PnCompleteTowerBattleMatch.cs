using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnCompleteTowerBattleMatch {
    [Key(0)]
    public TowerBattlePlayerInfoData OpponentPlayerInfoData { get; set; }
    [Key(1)]
    public int TurnUserId { get; set; }
}
