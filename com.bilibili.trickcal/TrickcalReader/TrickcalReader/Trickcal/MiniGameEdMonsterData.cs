using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MiniGameEdMonsterData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public MonsterType Type { get; set; }
    [Key(2)]
    public MonsterPersonalityType Personality { get; set; }
    [Key(3)]
    public string SpineBattle { get; set; }
    [Key(4)]
    public float Scale { get; set; }
    [Key(5)]
    public float Hp { get; set; }
    [Key(6)]
    public float MoveSpeed { get; set; }
    [Key(7)]
    public float DamageReceiveDownPercent { get; set; }
    [Key(8)]
    public int RewardValue01 { get; set; }
    [Key(9)]
    public int RewardValue02 { get; set; }
    [Key(10)]
    public int RewardScore { get; set; }
    [Key(11)]
    public string Name { get; set; }
    [Key(12)]
    public float BossSpineScale { get; set; }
    [Key(13)]
    public string BossSpineTintColor { get; set; }
}
