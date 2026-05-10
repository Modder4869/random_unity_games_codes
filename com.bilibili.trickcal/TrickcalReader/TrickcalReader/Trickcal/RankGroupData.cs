using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class RankGroupData : TableItem<TableData> {
    [Key(0)]
    public int GroupOrder { get; set; }
    [Key(1)]
    public GroupType GroupType { get; set; }
    [Key(3)]
    public ContentsType ContentsType { get; set; }
    [Key(4)]
    public ClassificationType FirstClassificationType { get; set; }
    [Key(5)]
    public int ClassificationSpot { get; set; }
    [Key(6)]
    public string FirstGroupDesc { get; set; }
    [Key(7)]
    public int SecondClassificationUserNum { get; set; }
    [Key(8)]
    public int SecondClassificationNextGroupNum { get; set; }
    [Key(9)]
    public int[] Params { get; set; }
    [Key(10)]
    public string GroupTypeName { get; set; }
}
