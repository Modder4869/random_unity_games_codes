using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSkipStageAside {
    [Key(0)]
    public int StageUid { get; set; }
    [Key(1)]
    public int SkipCount { get; set; }
}
