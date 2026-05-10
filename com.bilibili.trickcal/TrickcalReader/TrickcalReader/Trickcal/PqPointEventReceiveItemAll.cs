using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqPointEventReceiveItemAll {
    [Key(0)]
    public int MixedEventUid { get; set; }
}
