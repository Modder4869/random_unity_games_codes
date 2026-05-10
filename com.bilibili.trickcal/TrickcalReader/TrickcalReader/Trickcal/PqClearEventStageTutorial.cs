using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqClearEventStageTutorial {
    [Key(0)]
    public int StageUid { get; set; }
}
