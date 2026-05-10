using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LifeRewardEventData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Unit { get; set; }
    [Key(2)]
    public string Ani { get; set; }
    [Key(3)]
    public string Desc { get; set; }
    [Key(4)]
    public int DropUid { get; set; }
}
