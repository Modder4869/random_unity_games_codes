using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PvpBoxRewardData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public TierGrade TierGrade { get; set; }
    [Key(2)]
    public TreasureBoxGradeType TreasureBoxGradeType { get; set; }
    [Key(3)]
    public int[] TreasureBoxProb { get; set; }
}
