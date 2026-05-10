using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TierSetData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public TierGrade TierGrade { get; set; }
    [Key(2)]
    public int ScoreCheck { get; set; }
    [Key(3)]
    public int RankCheck { get; set; }
    [Key(4)]
    public int RankInitializeScore { get; set; }
}
