using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetSoloRaidClearInfos {
    [Key(0)]
    public List<SoloRaidStageClearInfoData> StageClearInfos { get; set; }
}
