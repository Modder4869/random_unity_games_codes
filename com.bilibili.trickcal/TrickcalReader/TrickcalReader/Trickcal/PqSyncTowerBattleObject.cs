using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSyncTowerBattleObject {
    [Key(0)]
    public int SeasonId { get; set; }
    [Key(1)]
    public Vector2 Position { get; set; }
    [Key(2)]
    public float Rotation { get; set; }
}
