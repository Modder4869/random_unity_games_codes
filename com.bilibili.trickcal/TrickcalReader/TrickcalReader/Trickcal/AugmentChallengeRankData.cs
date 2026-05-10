using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AugmentChallengeRankData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public ContentsType Content { get; set; }
    [Key(2)]
    public AugmentChallengeRank Rank { get; set; }
    [Key(3)]
    public string Icon { get; set; }
    [Key(4)]
    public int MinValue { get; set; }
}
