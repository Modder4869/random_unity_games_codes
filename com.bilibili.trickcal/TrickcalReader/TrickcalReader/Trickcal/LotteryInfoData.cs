using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LotteryInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int LotteryGroupUid { get; set; }
    [Key(2)]
    public int DailyQuestGroupUid { get; set; }
    [Key(3)]
    public int AchievementGroupUid { get; set; }
    [Key(4)]
    public int Interaction { get; set; }
    [Key(5)]
    public int ExchangeItemUid { get; set; }
    [Key(6)]
    public int ExchangeItemCount { get; set; }
    [Key(7)]
    public string Prefab { get; set; }
    [Key(8)]
    public int HelpUid { get; set; }
    [Key(9)]
    public string BGM { get; set; }
}
