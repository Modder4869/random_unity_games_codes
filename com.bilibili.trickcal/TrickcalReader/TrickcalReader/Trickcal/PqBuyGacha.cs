using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqBuyGacha {
    [Key(0)]
    public int GachaDataUid { get; set; }
    [Key(1)]
    public int UseReplaceItemCount { get; set; }
}
