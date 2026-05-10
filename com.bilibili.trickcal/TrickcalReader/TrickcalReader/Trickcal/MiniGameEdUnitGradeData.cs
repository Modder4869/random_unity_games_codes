using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MiniGameEdUnitGradeData : TableItem<TableData> {
    [Key(0)]
    public int MiniGameUid { get; set; }
    [Key(1)]
    public int Uid { get; set; }
    [Key(2)]
    public int UnitInfoUid { get; set; }
    [Key(3)]
    public int[] MergeNeed { get; set; }
    [Key(4)]
    public string Name { get; set; }
    [Key(5)]
    public string DescAttackSize { get; set; }
    [Key(6)]
    public string DescAttackSpeed { get; set; }
    [Key(7)]
    public string DescAttackDamage { get; set; }
    [Key(8)]
    public string Icon { get; set; }
    [Key(9)]
    public int Grade { get; set; }
    [Key(10)]
    public float AttackDamage { get; set; }
    [Key(11)]
    public float AttackSpeed { get; set; }
    [Key(12)]
    public float AttackRange { get; set; }
    [Key(13)]
    public int SaleCost { get; set; }
    [Key(14)]
    public string DescSpecialAttack { get; set; }
}
