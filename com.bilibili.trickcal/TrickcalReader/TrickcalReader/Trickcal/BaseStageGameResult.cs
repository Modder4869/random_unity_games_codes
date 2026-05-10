using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class BaseStageGameResult {
    [Key(0)]
    public StageRouletteDrawInfo StageRouletteDrawInfo { get; set; }
    [Key(1)]
    public Dictionary<int, StageHeroInfo> StageHeroInfos { get; set; }
    [Key(2)]
    public List<StageWaveInfo> StageWaveInfos { get; set; }
    [Key(3)]
    public bool IsAllWaveClear { get; set; }
    [Key(4)]
    public bool IsFastBattleClear { get; set; }
}
