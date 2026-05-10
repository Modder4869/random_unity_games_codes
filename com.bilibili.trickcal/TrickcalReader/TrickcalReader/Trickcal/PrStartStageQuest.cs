using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrStartStageQuest {
    [Key(0)]
    public int StagePlayKey { get; set; }
    [Key(1)]
    public GuildHeroRentData GuildHeroRentData { get; set; }
    [Key(2)]
    public int GuildHeroRentKey { get; set; }
    [Key(3)]
    public BattleEnvironmentInfo BattleEnvironmentInfo { get; set; }
}
