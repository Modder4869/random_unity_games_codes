using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetSoloEndClearInfos {
    [Key(0)]
    public List<SoloEndClearInfoData> SoloEndClearInfos { get; set; }
}
