using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestProcessDayChange {
    [Key(0)]
    public bool IsWeekChange { get; set; }
    [Key(1)]
    public bool IsMonthChange { get; set; }
}
