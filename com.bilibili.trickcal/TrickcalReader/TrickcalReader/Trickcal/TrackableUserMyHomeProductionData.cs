using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserMyHomeProductionData {
    [Key(0)]
    public int RecipeUid { get; set; }
    [Key(1)]
    public DateTime StartTime { get; set; }
    [Key(2)]
    public DateTime CompleteTime { get; set; }
    [Key(3)]
    public int Count { get; set; }
}
