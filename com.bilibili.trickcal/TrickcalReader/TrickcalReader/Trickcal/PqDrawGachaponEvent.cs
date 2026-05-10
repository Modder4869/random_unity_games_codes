using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqDrawGachaponEvent {
    [Key(0)]
    public int GachaponEventUid { get; set; }
    [Key(1)]
    public int DrawCount { get; set; }
}
