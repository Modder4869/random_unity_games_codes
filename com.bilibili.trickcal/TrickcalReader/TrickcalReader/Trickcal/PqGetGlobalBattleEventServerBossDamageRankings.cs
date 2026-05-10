using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqGetGlobalBattleEventServerBossDamageRankings {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public int GlobalBattleEventUid { get; set; }
    [Key(2)]
    public int Page { get; set; }
    [Key(3)]
    public int Length { get; set; }
}
