using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestJoinTowerBattleRoom {
    [Key(0)]
    public string RoomId { get; set; }
    [Key(1)]
    public bool IsSinglePlay { get; set; }
}
