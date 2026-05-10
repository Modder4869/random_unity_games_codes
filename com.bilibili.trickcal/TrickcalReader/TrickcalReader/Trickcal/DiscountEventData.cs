using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DiscountEventData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int DiscountTargetParam { get; set; }
    [Key(2)]
    public int PriceDiscount { get; set; }
    [Key(3)]
    public int DiscountRate { get; set; }
    [Key(4)]
    public ContentsType ContentType { get; set; }
    [Key(5)]
    public DiscountTarget DiscountTarget { get; set; }
    [Key(6)]
    public string IconText { get; set; }
    [Key(7)]
    public QuestType[] BanAchievement { get; set; }
}
