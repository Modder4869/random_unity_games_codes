using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEndGachaponEvent {
    [Key(0)]
    public int GachaponEventUid { get; set; }
}
