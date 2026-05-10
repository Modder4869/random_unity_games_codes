using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TowerBattleObjectInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public TowerBattleObjectType ObjectType { get; set; }
    [Key(2)]
    public TowerBattleObjectActionType ActionType { get; set; }
    [Key(3)]
    public float Size { get; set; }
    [Key(4)]
    public float Weight { get; set; }
    [Key(5)]
    public float Friction { get; set; }
    [Key(6)]
    public float Bounciness { get; set; }
    [Key(7)]
    public string Name { get; set; }
    [Key(8)]
    public string Desc { get; set; }
    [Key(9)]
    public string ShapeImage { get; set; }
    [Key(10)]
    public string Prefab { get; set; }
    [Key(11)]
    public string Voice { get; set; }
}
