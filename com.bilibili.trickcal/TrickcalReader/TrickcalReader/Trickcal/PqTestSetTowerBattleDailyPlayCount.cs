using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetTowerBattleDailyPlayCount {
    [Key(0)]
    public int Season { get; set; }
    [Key(1)]
    public int DailyPlayCount { get; set; }
}
