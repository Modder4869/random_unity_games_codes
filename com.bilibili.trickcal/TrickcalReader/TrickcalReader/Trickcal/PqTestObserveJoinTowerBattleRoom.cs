using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestObserveJoinTowerBattleRoom {
    [Key(0)]
    public string RoomId { get; set; }
}
