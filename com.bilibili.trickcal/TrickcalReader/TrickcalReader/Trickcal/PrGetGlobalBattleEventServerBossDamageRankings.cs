using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetGlobalBattleEventServerBossDamageRankings {
    [Key(0)]
    public List<GlobalBattleEventRankingData> TopRankings { get; set; }
}
