using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class JoanneMiniGameServerResultData {
    [Key(0)]
    public int? Ending { get; set; }
}
