using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WWERoundScheduleData {
    [Key(0)]
    public int Round { get; set; }
    [Key(1)]
    public int[] MatchIds { get; set; }
    [Key(2)]
    public DateTime StartTime { get; set; }
    [Key(3)]
    public DateTime EndTime { get; set; }
}
