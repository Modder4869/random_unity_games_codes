using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserSoloEndWorldData {
    [Key(0)]
    public int[] UsedHeroes { get; set; }
    [Key(1)]
    public int LastClearedStageId { get; set; }
    [Key(2)]
    public int LastFirstClearedStageId { get; set; }
    [Key(3)]
    public int ResetCount { get; set; }
    [Key(4)]
    public int GroupId { get; set; }
}
