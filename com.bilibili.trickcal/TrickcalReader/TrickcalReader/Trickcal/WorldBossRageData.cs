using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WorldBossRageData : TableItem<TableData> {
    [Key(0)]
    public int StageUid { get; set; }
    [Key(1)]
    public float RageTime { get; set; }
    [Key(2)]
    public int RageCount { get; set; }
    [Key(3)]
    public string StatusEffectUid { get; set; }
    [Key(4)]
    public float StatusEffectDuration { get; set; }
    [Key(5)]
    public float StatusEffectValue { get; set; }
}
