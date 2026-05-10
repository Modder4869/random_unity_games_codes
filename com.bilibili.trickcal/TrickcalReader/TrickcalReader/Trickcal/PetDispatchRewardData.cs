using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PetDispatchRewardData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int TaskUid { get; set; }
    [Key(2)]
    public int RankUid { get; set; }
    [Key(3)]
    public int TaskMinute { get; set; }
    [Key(4)]
    public int DropUid { get; set; }
}
