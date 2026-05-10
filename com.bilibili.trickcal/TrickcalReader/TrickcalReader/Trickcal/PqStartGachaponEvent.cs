using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqStartGachaponEvent {
    [Key(0)]
    public int GachaponEventUid { get; set; }
}
