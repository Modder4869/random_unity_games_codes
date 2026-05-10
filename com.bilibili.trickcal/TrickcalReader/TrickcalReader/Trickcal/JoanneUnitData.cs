using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class JoanneUnitData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public JoanneUnitTypes Type { get; set; }
    [Key(2)]
    public JoanneUnitGrade Grade { get; set; }
    [Key(3)]
    public int HP { get; set; }
    [Key(4)]
    public int SP { get; set; }
    [Key(5)]
    public int Atk { get; set; }
    [Key(6)]
    public int AtkRange { get; set; }
    [Key(7)]
    public float AtkSpeed { get; set; }
    [Key(8)]
    public int Damage { get; set; }
    [Key(9)]
    public float MoveSpeed { get; set; }
    [Key(10)]
    public int StartControl { get; set; }
    [Key(11)]
    public int Point { get; set; }
    [Key(12)]
    public float BattleTime { get; set; }
    [Key(13)]
    public float PatrolRange { get; set; }
    [Key(14)]
    public float RestMin { get; set; }
    [Key(15)]
    public float RestMax { get; set; }
    [Key(16)]
    public int UnitUid { get; set; }
    [Key(17)]
    public string Idle { get; set; }
    [Key(18)]
    public string Moving { get; set; }
    [Key(19)]
    public string AttackAni { get; set; }
    [Key(20)]
    public string DefeatAni { get; set; }
    [Key(21)]
    public string DeathAni { get; set; }
    [Key(22)]
    public string Ultimate { get; set; }
    [Key(23)]
    public string SpawnVoice { get; set; }
}
