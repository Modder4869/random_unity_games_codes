using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserCardDeckData {
    [Key(0)]
    public int[] DisabledCards { get; set; }
    [Key(1)]
    public string Name { get; set; }
}
