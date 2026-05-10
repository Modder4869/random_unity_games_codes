using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GachaPickUpCardData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int GachaInfoUid { get; set; }
    [Key(2)]
    public NeedItemType NeedItemType { get; set; }
    [Key(3)]
    public int NeedItemUid { get; set; }
    [Key(4)]
    public int NeedItemCount { get; set; }
    [Key(5)]
    public int[] RewardCard { get; set; }
    [Key(6)]
    public int Slot { get; set; }
}
