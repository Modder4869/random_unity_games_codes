using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqClearEventStageQuest {
    [Key(0)]
    public int StageUid { get; set; }
}
