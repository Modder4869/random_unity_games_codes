using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WWERecordData : TableItem<TableData> {
    [Key(1)]
    public int Frame { get; set; }
    [Key(2)]
    public int UnitUid { get; set; }
    [Key(3)]
    public float AxisX { get; set; }
    [Key(4)]
    public float AxisY { get; set; }
    [Key(5)]
    public float AxisZ { get; set; }
    [Key(6)]
    public string TargetGUID { get; set; }
    [Key(7)]
    public string Animation { get; set; }
    [Key(9)]
    public string Hp { get; set; }
    [Key(10)]
    public string Sp { get; set; }
    [Key(11)]
    public string TakeDamage { get; set; }
    [Key(12)]
    public AttackType TakeAttackType { get; set; }
    [Key(13)]
    public bool IsCritical { get; set; }
    [Key(14)]
    public string WeakType { get; set; }
    [Key(15)]
    public string Heal { get; set; }
    [Key(18)]
    public int CurSp { get; set; }
    [Key(19)]
    public string UnitGUID { get; set; }
    [Key(20)]
    public string MaxHp { get; set; }
    [Key(22)]
    public string Polymorph { get; set; }
    [Key(23)]
    public bool IsLoop { get; set; }
    [Key(24)]
    public float AniTimeScale { get; set; }
    [Key(25)]
    public int GetSp { get; set; }
}
