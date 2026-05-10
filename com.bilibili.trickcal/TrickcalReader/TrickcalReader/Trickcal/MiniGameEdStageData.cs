using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MiniGameEdStageData : TableItem<TableData> {
    [Key(0)]
    public int MiniGameStageUid { get; set; }
    [Key(1)]
    public int Wave { get; set; }
    [Key(2)]
    public int NextWave { get; set; }
    [Key(3)]
    public int StartReward01 { get; set; }
    [Key(4)]
    public int BattleTime { get; set; }
    [Key(5)]
    public bool BossBattle { get; set; }
    [Key(6)]
    public int MonsterUid01 { get; set; }
    [Key(7)]
    public int MonsterValue01 { get; set; }
    [Key(8)]
    public float MonsterSpawnInterval { get; set; }
}
