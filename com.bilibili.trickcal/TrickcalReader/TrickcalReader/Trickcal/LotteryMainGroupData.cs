using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LotteryMainGroupData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string LotteryName { get; set; }
    [Key(2)]
    public LotteryType LotteryType { get; set; }
    [Key(3)]
    public LotteryRenewalType RenewalType { get; set; }
    [Key(4)]
    public int NeedItemUid { get; set; }
    [Key(5)]
    public int NeedItemPrice { get; set; }
    [Key(6)]
    public bool IsLastRoundLoop { get; set; }
    [Key(7)]
    public int InteractionUid { get; set; }
    [Key(8)]
    public int Group { get; set; }
}
