using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class BilibiliChainTypeGiftMasterData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int GroupId { get; set; }
    [Key(2)]
    public string Name { get; set; }
    [Key(3)]
    public int CashShopId { get; set; }
    [Key(4)]
    public string UnlockGift { get; set; }
    [Key(5)]
    public int FrontGift { get; set; }
    [Key(6)]
    public int Sort { get; set; }
}
