using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqBuyGachaPickUpItem {
    [Key(0)]
    public int PickUpDataUid { get; set; }
}
