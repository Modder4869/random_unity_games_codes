using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class RenewaMiniGame_TimeData {
    [Key(0)]
    public int TargetTime { get; set; }
    [Key(1)]
    public int PlayTime { get; set; }
    [Key(2)]
    public int Offset { get; set; }
}
