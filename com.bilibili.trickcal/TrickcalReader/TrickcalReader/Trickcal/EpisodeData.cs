using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class EpisodeData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int ChapterUid { get; set; }
    [Key(2)]
    public int EpisodeOrder { get; set; }
    [Key(3)]
    public EpisodeUnlockType[] EpisodeUnlockTypes { get; set; }
    [Key(4)]
    public int[] EpisodeUnlockValues { get; set; }
    [Key(5)]
    public string EpisodeName { get; set; }
    [Key(6)]
    public string Summary { get; set; }
    [Key(7)]
    public int Reward { get; set; }
    [Key(8)]
    public bool Active { get; set; }
    [Key(9)]
    public bool Rerun { get; set; }
    [Key(10)]
    public int ItemUnlockValue { get; set; }
    [Key(11)]
    public int RerunReward { get; set; }
    [Key(12)]
    public EpisodeUnlockType[] RerunEpisodeUnlockTypes { get; set; }
    [Key(13)]
    public int[] RerunEpisodeUnlockValues { get; set; }
}
