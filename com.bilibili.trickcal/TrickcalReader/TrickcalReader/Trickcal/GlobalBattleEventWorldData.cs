using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GlobalBattleEventWorldData : TableItem<TableData> {
    [Key(0)]
    public int GroupUid { get; set; }
    [Key(1)]
    public int WorldUid { get; set; }
    [Key(2)]
    public GlobalBattleEventWorldType WorldType { get; set; }
    [Key(3)]
    public int WorldOrder { get; set; }
    [Key(4)]
    public int WorldRule { get; set; }
    [Key(5)]
    public int[] UnlockStages { get; set; }
    [Key(6)]
    public int HardOpenDelayHours { get; set; }
    [Key(7)]
    public int VeryHardOpenDelayHours { get; set; }
    [Key(8)]
    public int ChallengeOpenDelayHours { get; set; }
}
