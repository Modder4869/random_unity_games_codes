using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqBuyGachaCardPickUpItem {
    [Key(0)]
    public int CardPickUpDataUid { get; set; }
    [Key(1)]
    public int Amount { get; set; }
}
