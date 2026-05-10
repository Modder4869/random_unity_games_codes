using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ChatEpisodeInfo : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int ChapterUid { get; set; }
    [Key(2)]
    public int EpisodeOrder { get; set; }
    [Key(3)]
    public string Title { get; set; }
    [Key(4)]
    public ContentsUnlockType[] EpisodeUnlockTypes { get; set; }
    [Key(5)]
    public int[] EpisodeUnlockValues { get; set; }
    [Key(6)]
    public RewardType RewardType { get; set; }
    [Key(7)]
    public int RewardUid { get; set; }
    [Key(8)]
    public int RewardValue { get; set; }
}
