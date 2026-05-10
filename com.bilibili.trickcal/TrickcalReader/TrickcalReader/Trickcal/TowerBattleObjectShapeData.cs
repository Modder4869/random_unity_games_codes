using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TowerBattleObjectShapeData {
    [Key(0)]
    public int Id { get; set; }
    [Key(1)]
    public List<List<Vector2>> Vertices { get; set; }
}
