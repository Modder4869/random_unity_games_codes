using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MiniGameEdModeData : TableItem<TableData> {
    [Key(0)]
    public int MiniGameUid { get; set; }
    [Key(1)]
    public int MiniGameStageUid { get; set; }
    [Key(3)]
    public string ModeName { get; set; }
    [Key(4)]
    public string ModeDesc { get; set; }
    [Key(5)]
    public int Interaction { get; set; }
    [Key(6)]
    public MiniGameStageUnlockType UnlockType { get; set; }
    [Key(7)]
    public int[] UnlockValues { get; set; }
    [Key(8)]
    public int TowerGroupUid { get; set; }
    [Key(9)]
    public bool TimeBonusApply { get; set; }
    [Key(10)]
    public bool IsRepeat { get; set; }
    [Key(11)]
    public int RepeatNormalAddHp { get; set; }
    [Key(12)]
    public int RepeatBossAddHp { get; set; }
    [Key(13)]
    public float RepeatNormalAddMoveSpeed { get; set; }
    [Key(14)]
    public float RepeatBossAddMoveSpeed { get; set; }
    [Key(15)]
    public float RepeatNormalAddDamageReceiveDownPercent { get; set; }
    [Key(16)]
    public float RepeatBossAddDamageReceiveDownPercent { get; set; }
    [Key(17)]
    public int UnitCountMax { get; set; }
    [Key(18)]
    public int UnitGachaNeedValue01 { get; set; }
    [Key(19)]
    public int MonsterCountMax { get; set; }
    [Key(20)]
    public int[] RepeatNormalAddRewardValues { get; set; }
    [Key(21)]
    public int[] RepeatBossAddRewardValues { get; set; }
}
