using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GatherHeroData : TableItem<TableData> {
    [Key(0)]
    public int HeroInfoUid { get; set; }
    [Key(1)]
    public int Hp { get; set; }
    [Key(2)]
    public int AttackPhysic { get; set; }
    [Key(3)]
    public int AttackMagic { get; set; }
    [Key(4)]
    public int DefensePhysic { get; set; }
    [Key(5)]
    public int DefenseMagic { get; set; }
    [Key(6)]
    public int CriticalRate { get; set; }
    [Key(7)]
    public int CriticalMult { get; set; }
    [Key(8)]
    public int CriticalResist { get; set; }
    [Key(9)]
    public int CriticalMultResist { get; set; }
}
