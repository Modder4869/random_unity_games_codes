using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqChoiceEventChoice {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int ChoiceUid { get; set; }
}
