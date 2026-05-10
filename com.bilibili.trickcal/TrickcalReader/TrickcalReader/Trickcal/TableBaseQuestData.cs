using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TableBaseQuestData {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string TextKey { get; set; }
    [Key(2)]
    public int RequiredUserLevel { get; set; }
    [Key(3)]
    public int Sort { get; set; }
    [Key(4)]
    public int PrevQuestUid { get; set; }
    [Key(5)]
    public QuestType QuestType { get; set; }
    [Key(6)]
    public int[] Values { get; set; }
    [Key(7)]
    public RewardType[] RewardTypes { get; set; }
    [Key(8)]
    public int[] RewardUids { get; set; }
    [Key(9)]
    public int[] RewardValues { get; set; }
    [Key(10)]
    public int EventUid { get; set; }
    [Key(11)]
    public string DescKey { get; set; }
    [Key(12)]
    public ContentsType ContentsType { get; set; }
}
