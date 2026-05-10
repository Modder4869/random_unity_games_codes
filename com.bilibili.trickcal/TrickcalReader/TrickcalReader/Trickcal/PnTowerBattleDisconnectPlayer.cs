using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnTowerBattleDisconnectPlayer {
    [Key(0)]
    public int DisconnectUserId { get; set; }
}
