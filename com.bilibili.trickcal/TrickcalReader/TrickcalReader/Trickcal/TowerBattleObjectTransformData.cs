using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TowerBattleObjectTransformData {
    [Key(0)]
    public int Id { get; set; }
    [Key(1)]
    public Vector2 Position { get; set; }
    [Key(2)]
    public float Rotation { get; set; }
}
