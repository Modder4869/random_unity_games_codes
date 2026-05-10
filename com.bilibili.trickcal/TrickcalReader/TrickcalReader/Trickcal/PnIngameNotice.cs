using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnIngameNotice {
    [Key(0)]
    public DateTime SendTime { get; set; }
    [Key(1)]
    public string Message { get; set; }
    [Key(2)]
    public int PlayCount { get; set; }
    [Key(3)]
    public int PlaySpan { get; set; }
}
