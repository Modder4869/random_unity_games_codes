using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrStartStageGlobalBattleEventArea {
    [Key(0)]
    public int StagePlayKey { get; set; }
    [Key(1)]
    public BattleEnvironmentInfo BattleEnvironmentInfo { get; set; }
}
