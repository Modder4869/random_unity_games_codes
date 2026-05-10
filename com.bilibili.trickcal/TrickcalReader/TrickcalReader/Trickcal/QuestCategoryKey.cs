using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct QuestCategoryKey {
    [Key(0)]
    public QuestCategoryType Type { get; set; }
    [Key(1)]
    public QuestCategorySubType SubType { get; set; }
    [Key(2)]
    public int CategoryNumber { get; set; }
}
