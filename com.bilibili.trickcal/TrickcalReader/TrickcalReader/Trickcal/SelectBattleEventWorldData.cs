using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SelectBattleEventWorldData : TableItem<TableData> {
    [Key(0)]
    public int SelectBattleEventUid { get; set; }
    [Key(1)]
    public int WorldUid { get; set; }
    [Key(2)]
    public SelectBattleEventWorldType WorldType { get; set; }
    [Key(3)]
    public int WorldOrder { get; set; }
    [Key(4)]
    public ContentsUnlockType UnlockType { get; set; }
    [Key(5)]
    public int UnlockValue { get; set; }
    [Key(6)]
    public int HardOpenDelayHours { get; set; }
    [Key(7)]
    public int VeryHardOpenDelayHours { get; set; }
    [Key(8)]
    public int ChallengeOpenDelayHours { get; set; }
}
