using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class VelaMiniGameServerResultData {
    [Key(0)]
    public int? Ending { get; set; }
}
