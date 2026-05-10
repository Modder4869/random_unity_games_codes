using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CookingTycoonStageInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int ContentsUid { get; set; }
    [Key(2)]
    public CookingTycoonStageDifficulty Difficulty { get; set; }
    [Key(3)]
    public int PlayTime { get; set; }
    [Key(4)]
    public int OrderLimitNum { get; set; }
    [Key(5)]
    public int DetailPlayUid { get; set; }
    [Key(6)]
    public CookingTycoonUnlockType UnlockType { get; set; }
    [Key(7)]
    public int UnlockValue { get; set; }
    [Key(8)]
    public string StageName { get; set; }
    [Key(9)]
    public int PauseLimitNum { get; set; }
}
