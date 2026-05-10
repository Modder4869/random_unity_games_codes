using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ChapterData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int StoryUid { get; set; }
    [Key(2)]
    public int ChapterOrder { get; set; }
    [Key(3)]
    public int HeroUid { get; set; }
    [Key(4)]
    public string ChapterName { get; set; }
    [Key(5)]
    public string ChapterImage { get; set; }
    [Key(6)]
    public string EpisodeAmount { get; set; }
    [Key(7)]
    public bool Active { get; set; }
    [Key(8)]
    public bool IsRenewal { get; set; }
    [Key(9)]
    public int EpisodeResetCount { get; set; }
    [Key(10)]
    public int RewardResetCount { get; set; }
    [Key(11)]
    public int SeasonUid { get; set; }
    [Key(12)]
    public int[] RecommendEpisodes { get; set; }
    [Key(13)]
    public ContentsUnlockType ImageChangeType { get; set; }
    [Key(14)]
    public int ImageChangeValue { get; set; }
    [Key(15)]
    public DateTime ChangeDateUTC { get; set; }
    [Key(16)]
    public string ChangeChapterImage { get; set; }
}
