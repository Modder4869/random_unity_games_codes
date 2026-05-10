using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AugmentChallengeScorePerData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int HighAugmentCount { get; set; }
    [Key(2)]
    public int ScorePer { get; set; }
}
