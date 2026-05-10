using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StorySeasonData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int StoryUid { get; set; }
    [Key(2)]
    public int SeasonOrder { get; set; }
    [Key(3)]
    public string SeasonName { get; set; }
    [Key(4)]
    public string SeasonImage { get; set; }
    [Key(5)]
    public EpisodeUnlockType[] EpisodeUnlockTypes { get; set; }
    [Key(6)]
    public int[] EpisodeUnlockValues { get; set; }
    [Key(7)]
    public bool Active { get; set; }
}
