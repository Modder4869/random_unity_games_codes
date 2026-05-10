using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqChoiceEventReset {
    [Key(0)]
    public int MixedEventUid { get; set; }
}
