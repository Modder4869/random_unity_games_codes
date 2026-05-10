using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetUserSoloEndWorldPlayInfo {
    [Key(0)]
    public List<SoloEndClearInfoData> SoloEndClearInfos { get; set; }
}
