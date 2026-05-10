using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StageAugmentChallengeGameResult {
    [Key(0)]
    public BaseStageGameResult Base { get; set; }
    [Key(1)]
    public StagePowerData PowerData { get; set; }
    [Key(2)]
    public List<StageAugmentInfo> SelectAugmentInfos { get; set; }
    [Key(3)]
    public Dictionary<int, int> MonsterKillCount { get; set; }
    [Key(4)]
    public int Exp { get; set; }
    [Key(5)]
    public List<StageAugmentDrawInfo> StageAugmentDrawInfos { get; set; }
    [Key(6)]
    public int Score { get; set; }
}
