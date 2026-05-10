using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqStartStageStory {
    [Key(0)]
    public int EpisodeUid { get; set; }
    [Key(1)]
    public int StageUid { get; set; }
    [Key(2)]
    public PlayDeckData PlayDeckData { get; set; }
    [Key(3)]
    public bool IsAutoPlay { get; set; }
}
