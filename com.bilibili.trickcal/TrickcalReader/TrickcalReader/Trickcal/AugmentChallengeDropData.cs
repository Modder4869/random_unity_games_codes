using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AugmentChallengeDropData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public MonsterType MonsterType { get; set; }
    [Key(2)]
    public int[] DropUid { get; set; }
    [Key(3)]
    public int[] DropValueMin { get; set; }
    [Key(4)]
    public int[] DropValueMax { get; set; }
    [Key(5)]
    public int ScoreValue { get; set; }
}
