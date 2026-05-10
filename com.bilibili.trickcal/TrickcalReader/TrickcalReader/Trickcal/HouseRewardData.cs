using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HouseRewardData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public HouseRewardType Type { get; set; }
    [Key(2)]
    public int DropUid { get; set; }
}
