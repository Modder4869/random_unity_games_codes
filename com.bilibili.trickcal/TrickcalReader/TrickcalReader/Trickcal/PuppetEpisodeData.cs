using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PuppetEpisodeData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int LinkValue { get; set; }
    [Key(3)]
    public int EpisodeOrder { get; set; }
    [Key(4)]
    public EpisodeUnlockType[] EpisodeUnlockTypes { get; set; }
    [Key(5)]
    public int[] EpisodeUnlockValues { get; set; }
    [Key(6)]
    public string EpisodeName { get; set; }
    [Key(7)]
    public string LockMinimi { get; set; }
    [Key(8)]
    public string UnlockMinimi { get; set; }
    [Key(9)]
    public string Spine { get; set; }
    [Key(10)]
    public RewardType RewardType { get; set; }
    [Key(11)]
    public int RewardUid { get; set; }
    [Key(12)]
    public int RewardValue { get; set; }
    [Key(13)]
    public string EpisodeBGM { get; set; }
    [Key(14)]
    public PuppetEpisodeLinkType LinkType { get; set; }
}
