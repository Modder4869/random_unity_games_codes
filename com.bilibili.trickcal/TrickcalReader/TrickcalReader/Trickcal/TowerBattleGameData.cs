using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TowerBattleGameData {
    [Key(0)]
    public Dictionary<int, TowerBattleObjectShapeData> ShapeDatas { get; set; }
}
