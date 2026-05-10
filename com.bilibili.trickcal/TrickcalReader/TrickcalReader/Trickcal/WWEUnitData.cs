using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WWEUnitData {
    [Key(2)]
    public int UnitUid { get; set; }
    [Key(3)]
    public string TargetGUID { get; set; }
    [Key(4)]
    public string Animation { get; set; }
    [Key(5)]
    public string Hp { get; set; }
    [Key(6)]
    public string Sp { get; set; }
    [Key(7)]
    public string MaxHp { get; set; }
    [Key(8)]
    public int CurSp { get; set; }
    [Key(9)]
    public string Polymorph { get; set; }
    [Key(10)]
    public bool IsLoop { get; set; }
    [Key(11)]
    public float AniTimeScale { get; set; }
    [Key(12)]
    public float AxisX { get; set; }
    [Key(13)]
    public float AxisY { get; set; }
    [Key(14)]
    public float AxisZ { get; set; }
    [Key(15)]
    public float ScaleValue { get; set; }
    [Key(16)]
    public long AllTypeShield { get; set; }
    [Key(17)]
    public long PhysicTypeShield { get; set; }
    [Key(18)]
    public long MagicTypeShield { get; set; }
    [Key(19)]
    public bool Active { get; set; }
    [Key(20)]
    public bool LookRight { get; set; }
}
