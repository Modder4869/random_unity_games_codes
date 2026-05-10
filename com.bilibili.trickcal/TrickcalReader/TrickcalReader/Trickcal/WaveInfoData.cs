using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WaveInfoData {
    [Key(0)]
    public List<WaveData> WaveDataList { get; set; }
}
