using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserGachaRecordData {
    [Key(0)]
    public int GachaTotal { get; set; }
    [Key(1)]
    public int GachaDayTotal { get; set; }
    [Key(2)]
    public DateTime RefreshDayTime { get; set; }
}
