using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PetRewardData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int UserLevel { get; set; }
    [Key(2)]
    public int[] DropUids { get; set; }
}
