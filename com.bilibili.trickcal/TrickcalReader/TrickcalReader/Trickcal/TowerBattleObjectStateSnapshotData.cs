using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TowerBattleObjectStateSnapshotData {
    [Key(0)]
    public int Id { get; set; }
    [Key(1)]
    public int TowerBattleObjectInfoId { get; set; }
    [Key(2)]
    public Vector2 Position { get; set; }
    [Key(3)]
    public float Rotation { get; set; }
}
