using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetLastDailyRefreshTime {
    [Key(0)]
    public DateTime LastDailyRefreshTime { get; set; }
}
