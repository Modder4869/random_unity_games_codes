using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class QuestSeasonData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public QuestCategoryType CategoryType { get; set; }
    [Key(2)]
    public int Season { get; set; }
    [Key(3)]
    public DateTime StartTime { get; set; }
    [Key(4)]
    public RewardType[] ExpectedRewardTypes { get; set; }
    [Key(5)]
    public int[] ExpectedRewardValues { get; set; }
}
