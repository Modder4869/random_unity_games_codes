using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StoryFixBattleData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int EpisodeUid { get; set; }
    [Key(2)]
    public int StageUid { get; set; }
    [Key(3)]
    public StoryBattleType StoryBattleType { get; set; }
}
