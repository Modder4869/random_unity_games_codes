using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AnotherInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int TargetEpisodeUid { get; set; }
    [Key(2)]
    public int AnotherGroup { get; set; }
    [Key(3)]
    public string Desc { get; set; }
    [Key(4)]
    public string Prefab { get; set; }
}
