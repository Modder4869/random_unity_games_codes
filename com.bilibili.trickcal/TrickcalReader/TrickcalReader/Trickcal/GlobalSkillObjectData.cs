using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GlobalSkillObjectData : TableItem<TableData> {
    [Key(0)]
    public string Uid { get; set; }
    [Key(1)]
    public string Prefab { get; set; }
    [Key(2)]
    public double Duration { get; set; }
    [Key(3)]
    public GlobalMoveType MoveType { get; set; }
    [Key(4)]
    public double MoveSpeed { get; set; }
    [Key(5)]
    public bool LookDir { get; set; }
    [Key(6)]
    public string BoneSelf { get; set; }
    [Key(7)]
    public string BoneTarget { get; set; }
    [Key(8)]
    public bool FollowBone { get; set; }
    [Key(9)]
    public bool FollowTarget { get; set; }
    [Key(10)]
    public double Offset { get; set; }
    [Key(11)]
    public double SizeX { get; set; }
    [Key(12)]
    public GlobalSkillObjectCollisionType CollisionType { get; set; }
    [Key(13)]
    public bool DestroyOnCollision { get; set; }
    [Key(14)]
    public double Tick { get; set; }
    [Key(15)]
    public double TickDelay { get; set; }
    [Key(16)]
    public double SizeY { get; set; }
    [Key(17)]
    public double SizeZ { get; set; }
}
