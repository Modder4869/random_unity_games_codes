using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnCloseTowerBattleRoomForced {
    [Key(0)]
    public TowerBattleRoomCloseReason CloseReason { get; set; }
}
