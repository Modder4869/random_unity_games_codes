using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSkipStageQuest {
    [Key(0)]
    public int StageUid { get; set; }
    [Key(1)]
    public int SkipCount { get; set; }
    [Key(2)]
    public int TargetItemId { get; set; }
    [Key(3)]
    public int TargetItemCount { get; set; }
}
