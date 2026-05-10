using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HallOfFameGroup : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int GroupId { get; set; }
    [Key(2)]
    public int Day { get; set; }
    [Key(3)]
    public string Name { get; set; }
    [Key(4)]
    public string Desc { get; set; }
    [Key(5)]
    public string Resource { get; set; }
    [Key(6)]
    public int RewardUid { get; set; }
    [Key(7)]
    public int RewardValue { get; set; }
}
