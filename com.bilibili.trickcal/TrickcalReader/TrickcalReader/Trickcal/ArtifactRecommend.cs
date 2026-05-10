using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ArtifactRecommend : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public JobType RecommendClass1 { get; set; }
    [Key(2)]
    public JobType RecommendClass2 { get; set; }
    [Key(3)]
    public AttackType RecommendType { get; set; }
    [Key(4)]
    public RecommendCore RecommendCore1 { get; set; }
    [Key(5)]
    public RecommendCore RecommendCore2 { get; set; }
    [Key(6)]
    public bool InfoCheck { get; set; }
    [Key(7)]
    public JobType Job1 { get; set; }
    [Key(8)]
    public JobType Job2 { get; set; }
    [Key(9)]
    public AttackType AttackType { get; set; }
    [Key(10)]
    public RangeType RangeType { get; set; }
}
