using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqPointEventReceiveItem {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int ReceiveStep { get; set; }
}
