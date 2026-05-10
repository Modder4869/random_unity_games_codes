using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TowerBattleObjectSpawnData {
    [Key(0)]
    public int Id { get; set; }
    [Key(1)]
    public int TowerBattleObjectId { get; set; }
    [Key(2)]
    public Vector2 Position { get; set; }
}
