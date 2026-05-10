using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqAssembleEventReceiveItem {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int AssembleUid { get; set; }
}
