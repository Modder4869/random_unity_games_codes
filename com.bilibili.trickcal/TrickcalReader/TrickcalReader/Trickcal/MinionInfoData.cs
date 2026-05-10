using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MinionInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public SummonedObjectType Type { get; set; }
    [Key(2)]
    public AttackType AttackType { get; set; }
    [Key(3)]
    public RangeType RangeType { get; set; }
    [Key(4)]
    public PersonalityType Personality { get; set; }
    [Key(5)]
    public JobType Job { get; set; }
    [Key(6)]
    public TribeType Tribe { get; set; }
    [Key(7)]
    public bool UnMoveType { get; set; }
    [Key(8)]
    public string Name { get; set; }
    [Key(9)]
    public string Desc { get; set; }
    [Key(10)]
    public string SpineBattle { get; set; }
    [Key(11)]
    public string Icon { get; set; }
    [Key(12)]
    public int ItemDropRatio { get; set; }
    [Key(13)]
    public int DropCoinMin { get; set; }
    [Key(14)]
    public int DropCoinMax { get; set; }
    [Key(15)]
    public int Scale { get; set; }
    [Key(16)]
    public bool ImmuneStatusEffect { get; set; }
    [Key(17)]
    public bool MasterDeath { get; set; }
    [Key(18)]
    public bool DisplayHP { get; set; }
    [Key(19)]
    public bool BattleEndDeath { get; set; }
    [Key(20)]
    public string SkillOwner { get; set; }
    [Key(21)]
    public bool UseMasterScale { get; set; }
    [Key(22)]
    public int SpawnScale { get; set; }
    [Key(23)]
    public bool IgnoreHit { get; set; }
}
