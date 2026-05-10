using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AnotherModeGroupData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public int Order { get; set; }
    [Key(3)]
    public int EpisodeUid { get; set; }
    [Key(4)]
    public string SelectText { get; set; }
    [Key(5)]
    public string SelectDescText { get; set; }
    [Key(6)]
    public string SelectPrefab { get; set; }
    [Key(7)]
    public string SelectGuideText { get; set; }
    [Key(8)]
    public bool IsPass { get; set; }
}
