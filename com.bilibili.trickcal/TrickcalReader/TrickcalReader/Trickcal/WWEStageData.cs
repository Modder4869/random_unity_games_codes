using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WWEStageData {
    [Key(1)]
    public int Time { get; set; }
}
