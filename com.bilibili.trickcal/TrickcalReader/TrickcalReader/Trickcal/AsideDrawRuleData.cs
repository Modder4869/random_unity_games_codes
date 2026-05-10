using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AsideDrawRuleData : TableItem<TableData> {
    [Key(0)]
    public DrawCardType Type { get; set; }
    [Key(1)]
    public int BuyCount { get; set; }
    [Key(2)]
    public DrawCardType RewardType { get; set; }
    [Key(3)]
    public int[] RarityRate { get; set; }
    [Key(4)]
    public string Name { get; set; }
}
